﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using PriceCompareLogic;

namespace PriceCompare
{
    public partial class PriceCompareForm : Form
    {
        private ToolTip _toolTip = new ToolTip();
        private DatabaseOfItem _databaseOfShoppingCart = new DatabaseOfItem();
        private StoreFileManager _storeFileManager = new StoreFileManager();
        private char _spliter = ',';

        public PriceCompareForm()
        {
            InitializeComponent();
            var chainNames = _storeFileManager.GetDirectories();
            _toolTip.SetToolTip(_checkBoxToRemoveItem, "Check and select the item to change the quantity of the product.");
            _toolTip.SetToolTip(_checkBoxSelectStoresToCompare, "Check and select the branch to add to the  comperison list.");
            _cBoxChain.Items.AddRange(chainNames.ToArray<object>());
        }

        private void AddStoreNamesToCBox(FileIdentifiers fileIdentifiers, ComboBox cBoxStoreNames)
        {
            FileInfo[] filesInDir = _storeFileManager.GetFileInfo(fileIdentifiers);
            var xmlElementId = new XmlElementId() {
                DescendantFrom = "Store",
                ElementName = "StoreName",
                XmlFullPath = Path.Combine(fileIdentifiers.DirName, filesInDir[0].Name)};
             
            var storeNames = _storeFileManager.GetListOfElementsFromXml(xmlElementId);
            cBoxStoreNames.Items.Clear();
            cBoxStoreNames.Items.AddRange(storeNames.ToArray<object>());
        }

        private async void AddProductItemsToCBox(FileIdentifiers fileIdentifiers)
        {
            var items = new Dictionary<string, object>();
            var xmlElementId = new XmlElementId() {
                XmlFullPath = _storeFileManager.GetStoreFullPath(fileIdentifiers),
                DescendantFrom = "Item",
                ElementName = "ItemName"};

            _items.Items.Clear();

            await Task.Run(() =>
            {
                var listOfItems = _storeFileManager.GetListOfElementsFromXml(xmlElementId);
                foreach (var item in listOfItems)
                {
                    if (!items.ContainsKey(item))
                    {
                        items.Add(item, null);
                    }
                }
            });

            _items.Items.AddRange(items.Keys.ToArray<object>());
        }

        private void CBoxChains_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem != null)
            {
                var fileIdentifiers = new FileIdentifiers() {
                DirName = (string)(sender as ComboBox).SelectedItem,
                PartialFileName = "Stores"};
                AddStoreNamesToCBox(fileIdentifiers, _cBoxStores);
            }
        }

        private void Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!_shoppingCart.Items.Contains((sender as ComboBox).SelectedItem) && (sender as ComboBox).SelectedItem!= null)
            {
                _shoppingCart.Items.Add((sender as ComboBox).SelectedItem);
                _databaseOfShoppingCart.ItemsAndQuantities.Add(((string)(sender as ComboBox).SelectedItem), 1);
            }
        }

        private void ShoppingCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelected = (sender as ComboBox).SelectedItem;
            if ((sender as ComboBox).SelectedItem != null)
            {
                if (_checkBoxToRemoveItem.Checked)
                {
                    var quantitySelection = new QuantitySelectionForm();
                    quantitySelection.ShowForm();
                    if (quantitySelection.IsOkButtonPressed)
                    {
                        _databaseOfShoppingCart.ItemsAndQuantities[((string)itemSelected)] = quantitySelection.Amount;
                    }
                }
                else
                {
                    (sender as ComboBox).Items.Remove(itemSelected);
                    _databaseOfShoppingCart.ItemsAndQuantities.Remove(((string)itemSelected));
                }
            }

            _databaseOfShoppingCart.Items = _shoppingCart.Items.Cast<string>().ToList();
        }

        private void CBoxStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)(_cBoxChain.SelectedItem) != null && (string)(sender as ComboBox).SelectedItem != null)
            {
                var fileIdentifiers = new FileIdentifiers(){
                    DirName = (string)(_cBoxChain.SelectedItem),
                    PartialFileName = (string)(sender as ComboBox).SelectedItem};
                AddProductItemsToCBox(fileIdentifiers);
                var selectedBranch = $"{fileIdentifiers.DirName}{_spliter}{fileIdentifiers.PartialFileName}";

                if (_checkBoxSelectStoresToCompare.Checked && !_cBoxStoresToCompare.Items.Contains(selectedBranch))
                {
                    _cBoxStoresToCompare.Items.Add(selectedBranch);
                }
            }
            else
            {
                ShowWarning("Please select 1 chain and 1 branch");
            }
        }

        private void CBoxStoresToCompare_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((sender as ComboBox).SelectedItem != null)
            {
                _cBoxStoresToCompare.Items.Remove((string)(sender as ComboBox).SelectedItem);
            }
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            if (_shoppingCart.Items.Count == 0)
            {
                ShowWarning("Please select items to compare");
            }
            else if (_cBoxStores.SelectedItem == null || _cBoxChain.SelectedItem == null || _cBoxStoresToCompare.Items.Count == 0)
            {
                ShowWarning("Please select at list 1 chain and 1 branch");
            }
            else
            {
                List<FileIdentifiers> stores = new List<FileIdentifiers>();
                foreach (string chainAndBranchName in _cBoxStoresToCompare.Items)
                {
                    string[] chainAndBranch = chainAndBranchName.Split(_spliter);
                    var store = new FileIdentifiers(){
                        DirName = chainAndBranch[0], PartialFileName = chainAndBranch[1]};
                    stores.Add(store);
                }

                var fullReportOfStores = _storeFileManager.FullReportOfStores(stores, _databaseOfShoppingCart);
                var reportForm = new Report(fullReportOfStores);
                reportForm.Show();
            }
        }

        private void ShowWarning(string warningMsg)
        {
            MessageBox.Show(warningMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (_shoppingCart.Items.Count != 0)
            {
                using (var dialog = new SaveFileDialog())
                {
                    dialog.DefaultExt = "*.txt";
                    dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    DialogResult result = dialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string filename = dialog.FileName;
                        _storeFileManager.SaveFile(filename, _databaseOfShoppingCart);
                    }
                }
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((openFileDialog.OpenFile()) != null)
                {
                    _shoppingCart.Items.Clear();
                    var databaseOfItemDeserialize = _storeFileManager.LoadFile(openFileDialog.FileName);
                    if(databaseOfItemDeserialize != null)
                    {
                        _databaseOfShoppingCart = databaseOfItemDeserialize;
                        _shoppingCart.Items.AddRange(_databaseOfShoppingCart.Items.ToArray());
                    }
                    else
                    {
                        ShowWarning("Wrong File selected please select different one");
                    }
                }
            }
        }
    }
}
