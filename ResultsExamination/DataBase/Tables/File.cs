using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsExamination.DataBase.Tables
{
    /// <summary>
    /// Файл базы данных
    /// </summary>
    public class File
    {
        public File()
        {
        }

        public File(string path)
        {
            PreLoad(path);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }

        /// <summary>
        /// Предварительная загрузка для отправки в базу данных
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool PreLoad(string path)
        {
            bool res = true;
            try
            {
                using (System.IO.FileStream fs = new System.IO.FileStream(path, FileMode.Open))
                {
                    Data = new byte[fs.Length];
                    fs.Read(Data, 0, Data.Length);
                }
            }
            catch (Exception ex)
            {
                res = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return res;
        }

        /// <summary>
        /// Сохранить файл на ПК
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual bool Save(string path)
        {
            bool res = true;
            try
            {
                using (System.IO.FileStream fs = new System.IO.FileStream(path, FileMode.Create))
                {
                    fs.Write(Data, 0, Data.Length);
                }
            }
            catch (Exception ex)
            {
                res = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return res;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
