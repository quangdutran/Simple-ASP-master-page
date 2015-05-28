﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WebDatabase")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertAbout(About instance);
  partial void UpdateAbout(About instance);
  partial void DeleteAbout(About instance);
  partial void InsertContact(Contact instance);
  partial void UpdateContact(Contact instance);
  partial void DeleteContact(Contact instance);
  partial void InsertPortfolio(Portfolio instance);
  partial void UpdatePortfolio(Portfolio instance);
  partial void DeletePortfolio(Portfolio instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WebDatabaseConnectionString1"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<About> Abouts
	{
		get
		{
			return this.GetTable<About>();
		}
	}
	
	public System.Data.Linq.Table<Contact> Contacts
	{
		get
		{
			return this.GetTable<Contact>();
		}
	}
	
	public System.Data.Linq.Table<Portfolio> Portfolios
	{
		get
		{
			return this.GetTable<Portfolio>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.About")]
public partial class About : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _name;
	
	private string _class;
	
	private string _information;
	
	private string _img;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnclassChanging(string value);
    partial void OnclassChanged();
    partial void OninformationChanging(string value);
    partial void OninformationChanged();
    partial void OnimgChanging(string value);
    partial void OnimgChanged();
    #endregion
	
	public About()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string name
	{
		get
		{
			return this._name;
		}
		set
		{
			if ((this._name != value))
			{
				this.OnnameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("name");
				this.OnnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="class", Storage="_class", DbType="VarChar(20)")]
	public string @class
	{
		get
		{
			return this._class;
		}
		set
		{
			if ((this._class != value))
			{
				this.OnclassChanging(value);
				this.SendPropertyChanging();
				this._class = value;
				this.SendPropertyChanged("@class");
				this.OnclassChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_information", DbType="VarChar(150)")]
	public string information
	{
		get
		{
			return this._information;
		}
		set
		{
			if ((this._information != value))
			{
				this.OninformationChanging(value);
				this.SendPropertyChanging();
				this._information = value;
				this.SendPropertyChanged("information");
				this.OninformationChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_img", DbType="VarChar(50)")]
	public string img
	{
		get
		{
			return this._img;
		}
		set
		{
			if ((this._img != value))
			{
				this.OnimgChanging(value);
				this.SendPropertyChanging();
				this._img = value;
				this.SendPropertyChanged("img");
				this.OnimgChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Contact")]
public partial class Contact : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _name;
	
	private string _email;
	
	private System.Nullable<int> _phone;
	
	private string _message;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnphoneChanging(System.Nullable<int> value);
    partial void OnphoneChanged();
    partial void OnmessageChanging(string value);
    partial void OnmessageChanged();
    #endregion
	
	public Contact()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50)")]
	public string name
	{
		get
		{
			return this._name;
		}
		set
		{
			if ((this._name != value))
			{
				this.OnnameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("name");
				this.OnnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
	public string email
	{
		get
		{
			return this._email;
		}
		set
		{
			if ((this._email != value))
			{
				this.OnemailChanging(value);
				this.SendPropertyChanging();
				this._email = value;
				this.SendPropertyChanged("email");
				this.OnemailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="Int")]
	public System.Nullable<int> phone
	{
		get
		{
			return this._phone;
		}
		set
		{
			if ((this._phone != value))
			{
				this.OnphoneChanging(value);
				this.SendPropertyChanging();
				this._phone = value;
				this.SendPropertyChanged("phone");
				this.OnphoneChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_message", DbType="VarChar(MAX)")]
	public string message
	{
		get
		{
			return this._message;
		}
		set
		{
			if ((this._message != value))
			{
				this.OnmessageChanging(value);
				this.SendPropertyChanging();
				this._message = value;
				this.SendPropertyChanged("message");
				this.OnmessageChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Portfolio")]
public partial class Portfolio : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _projectName;
	
	private string _briefDescription;
	
	private string _detail;
	
	private string _imageS;
	
	private string _imageL;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnprojectNameChanging(string value);
    partial void OnprojectNameChanged();
    partial void OnbriefDescriptionChanging(string value);
    partial void OnbriefDescriptionChanged();
    partial void OndetailChanging(string value);
    partial void OndetailChanged();
    partial void OnimageSChanging(string value);
    partial void OnimageSChanged();
    partial void OnimageLChanging(string value);
    partial void OnimageLChanged();
    #endregion
	
	public Portfolio()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_projectName", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string projectName
	{
		get
		{
			return this._projectName;
		}
		set
		{
			if ((this._projectName != value))
			{
				this.OnprojectNameChanging(value);
				this.SendPropertyChanging();
				this._projectName = value;
				this.SendPropertyChanged("projectName");
				this.OnprojectNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_briefDescription", DbType="NChar(100)")]
	public string briefDescription
	{
		get
		{
			return this._briefDescription;
		}
		set
		{
			if ((this._briefDescription != value))
			{
				this.OnbriefDescriptionChanging(value);
				this.SendPropertyChanging();
				this._briefDescription = value;
				this.SendPropertyChanged("briefDescription");
				this.OnbriefDescriptionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_detail", DbType="NVarChar(MAX)")]
	public string detail
	{
		get
		{
			return this._detail;
		}
		set
		{
			if ((this._detail != value))
			{
				this.OndetailChanging(value);
				this.SendPropertyChanging();
				this._detail = value;
				this.SendPropertyChanged("detail");
				this.OndetailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imageS", DbType="VarChar(100)")]
	public string imageS
	{
		get
		{
			return this._imageS;
		}
		set
		{
			if ((this._imageS != value))
			{
				this.OnimageSChanging(value);
				this.SendPropertyChanging();
				this._imageS = value;
				this.SendPropertyChanged("imageS");
				this.OnimageSChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imageL", DbType="VarChar(100)")]
	public string imageL
	{
		get
		{
			return this._imageL;
		}
		set
		{
			if ((this._imageL != value))
			{
				this.OnimageLChanging(value);
				this.SendPropertyChanging();
				this._imageL = value;
				this.SendPropertyChanged("imageL");
				this.OnimageLChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#pragma warning restore 1591
