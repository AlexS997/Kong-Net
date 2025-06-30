using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.Classi
{
    internal class ClsMaxLenght
    {
        public class ColumnInfo
        {
            public string FieldName { get; set; }
            public int Length { get; set; }
        }

        //Method that receives an instance of ClsTableSchema
        public void SetMaxLength(Form form, ClsTableSchema tableSchema)
        {
            // Create a list of ColumnInfo based on the table schema
            List<ColumnInfo> columnInfos = new List<ColumnInfo>();

            // Gather information from the table scheme in a list
            foreach (var column in tableSchema.Colonnes)
            {
                columnInfos.Add(new ColumnInfo
                {
                    FieldName = column.Nome,
                    Length = column.Lunghezza
                });
            }

            // Set max length to TextBox depending on the scheme obtained
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                {
                    var binding = textBox.DataBindings["Text"];
                    if (binding != null)
                    {
                        string boundFieldName = binding.BindingMemberInfo.BindingField;
                        foreach (var columnInfo in columnInfos)
                        {
                            if (boundFieldName == columnInfo.FieldName)
                            {
                                textBox.MaxLength = columnInfo.Length;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
