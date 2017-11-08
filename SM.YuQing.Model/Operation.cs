﻿using System;
namespace SM.YuQing.Model
{
    /// <summary>
    /// Operation:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Operation
    {
        public Operation()
        { }
        #region Model
        private int _id;
        private string _name;
        private string _function;
        private string _icons;
        private int _sort;
        private DateTime _createtime;
        private string _createperson;
        private DateTime _updatetime;
        private string _updateperson;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Function
        {
            set { _function = value; }
            get { return _function; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Icons
        {
            set { _icons = value; }
            get { return _icons; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Sort
        {
            set { _sort = value; }
            get { return _sort; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CreatePerson
        {
            set { _createperson = value; }
            get { return _createperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateTime
        {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UpdatePerson
        {
            set { _updateperson = value; }
            get { return _updateperson; }
        }
        #endregion Model

    }
}