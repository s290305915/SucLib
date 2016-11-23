using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SucLib.Core
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method |
        AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class DataMapAttribute : Attribute
    {
        private string tableName;
        /// <summary>
        /// 实体实际对应的表名
        /// </summary>
        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        private string columnName;
        /// <summary>
        /// 中文列名
        /// </summary>
        public string Column
        {
            get { return columnName; }
            set { columnName = value; }
        }
        private string belongsto;
        /// <summary>
        /// 多对应关系(表)
        /// </summary>
        public string BelongsTo
        {
            get { return belongsto; }
            set { belongsto = value; }
        }
        private string belongstokey;
        /// <summary>
        /// 对应表的ID啊标识之类的
        /// </summary>
        public string BelongsToKey
        {
            get { return belongstokey; }
            set { belongstokey = value; }
        }
        private string hasmany;
        /// <summary>
        /// 表示有一对多的关系 list<T>
        /// </summary>
        public string HasMany
        {
            get { return hasmany; }
            set { hasmany = value; }
        }

        private string targetkey;
        /// <summary>
        /// 对应表的标识
        /// </summary>
        public string TargetKey
        {
            get { return targetkey; }
            set { targetkey = value; }
        }
    }
}
