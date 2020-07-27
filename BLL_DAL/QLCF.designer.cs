﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLL_DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLQuanCF")]
	public partial class QLCFDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBan(Ban instance);
    partial void UpdateBan(Ban instance);
    partial void DeleteBan(Ban instance);
    partial void InsertQL_NguoiDung(QL_NguoiDung instance);
    partial void UpdateQL_NguoiDung(QL_NguoiDung instance);
    partial void DeleteQL_NguoiDung(QL_NguoiDung instance);
    partial void InsertChiTietHoaDon(ChiTietHoaDon instance);
    partial void UpdateChiTietHoaDon(ChiTietHoaDon instance);
    partial void DeleteChiTietHoaDon(ChiTietHoaDon instance);
    partial void InsertChiTietThucDon(ChiTietThucDon instance);
    partial void UpdateChiTietThucDon(ChiTietThucDon instance);
    partial void DeleteChiTietThucDon(ChiTietThucDon instance);
    partial void InsertHoaDon(HoaDon instance);
    partial void UpdateHoaDon(HoaDon instance);
    partial void DeleteHoaDon(HoaDon instance);
    partial void InsertLoaiThucDon(LoaiThucDon instance);
    partial void UpdateLoaiThucDon(LoaiThucDon instance);
    partial void DeleteLoaiThucDon(LoaiThucDon instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    #endregion
		
		public QLCFDataContext() : 
				base(global::BLL_DAL.Properties.Settings.Default.QLQuanCFConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLCFDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLCFDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLCFDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLCFDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Ban> Bans
		{
			get
			{
				return this.GetTable<Ban>();
			}
		}
		
		public System.Data.Linq.Table<QL_NguoiDung> QL_NguoiDungs
		{
			get
			{
				return this.GetTable<QL_NguoiDung>();
			}
		}
		
		public System.Data.Linq.Table<ChiTietHoaDon> ChiTietHoaDons
		{
			get
			{
				return this.GetTable<ChiTietHoaDon>();
			}
		}
		
		public System.Data.Linq.Table<ChiTietThucDon> ChiTietThucDons
		{
			get
			{
				return this.GetTable<ChiTietThucDon>();
			}
		}
		
		public System.Data.Linq.Table<HoaDon> HoaDons
		{
			get
			{
				return this.GetTable<HoaDon>();
			}
		}
		
		public System.Data.Linq.Table<LoaiThucDon> LoaiThucDons
		{
			get
			{
				return this.GetTable<LoaiThucDon>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ban")]
	public partial class Ban : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaBan;
		
		private EntitySet<ChiTietHoaDon> _ChiTietHoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaBanChanging(string value);
    partial void OnMaBanChanged();
    #endregion
		
		public Ban()
		{
			this._ChiTietHoaDons = new EntitySet<ChiTietHoaDon>(new Action<ChiTietHoaDon>(this.attach_ChiTietHoaDons), new Action<ChiTietHoaDon>(this.detach_ChiTietHoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBan", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaBan
		{
			get
			{
				return this._MaBan;
			}
			set
			{
				if ((this._MaBan != value))
				{
					this.OnMaBanChanging(value);
					this.SendPropertyChanging();
					this._MaBan = value;
					this.SendPropertyChanged("MaBan");
					this.OnMaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ban_ChiTietHoaDon", Storage="_ChiTietHoaDons", ThisKey="MaBan", OtherKey="Ban")]
		public EntitySet<ChiTietHoaDon> ChiTietHoaDons
		{
			get
			{
				return this._ChiTietHoaDons;
			}
			set
			{
				this._ChiTietHoaDons.Assign(value);
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
		
		private void attach_ChiTietHoaDons(ChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.Ban1 = this;
		}
		
		private void detach_ChiTietHoaDons(ChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.Ban1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QL_NguoiDung")]
	public partial class QL_NguoiDung : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TenDangNhap;
		
		private string _MatKhau;
		
		private System.Nullable<bool> _HoatDong;
		
		private string _MaNV;
		
		private EntityRef<NhanVien> _NhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTenDangNhapChanging(string value);
    partial void OnTenDangNhapChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnHoatDongChanging(System.Nullable<bool> value);
    partial void OnHoatDongChanged();
    partial void OnMaNVChanging(string value);
    partial void OnMaNVChanged();
    #endregion
		
		public QL_NguoiDung()
		{
			this._NhanVien = default(EntityRef<NhanVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDangNhap", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TenDangNhap
		{
			get
			{
				return this._TenDangNhap;
			}
			set
			{
				if ((this._TenDangNhap != value))
				{
					this.OnTenDangNhapChanging(value);
					this.SendPropertyChanging();
					this._TenDangNhap = value;
					this.SendPropertyChanged("TenDangNhap");
					this.OnTenDangNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(50)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoatDong", DbType="Bit")]
		public System.Nullable<bool> HoatDong
		{
			get
			{
				return this._HoatDong;
			}
			set
			{
				if ((this._HoatDong != value))
				{
					this.OnHoatDongChanging(value);
					this.SendPropertyChanging();
					this._HoatDong = value;
					this.SendPropertyChanged("HoatDong");
					this.OnHoatDongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="NChar(10)")]
		public string MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_QL_NguoiDung", Storage="_NhanVien", ThisKey="MaNV", OtherKey="MaNV", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.QL_NguoiDungs.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.QL_NguoiDungs.Add(this);
						this._MaNV = value.MaNV;
					}
					else
					{
						this._MaNV = default(string);
					}
					this.SendPropertyChanged("NhanVien");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietHoaDon")]
	public partial class ChiTietHoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHD;
		
		private string _Ban;
		
		private string _TenMon;
		
		private System.Nullable<short> _SoLuong;
		
		private string _DonGia;
		
		private System.Nullable<double> _TongCong;
		
		private string _MaMon;
		
		private EntityRef<Ban> _Ban1;
		
		private EntityRef<ChiTietThucDon> _ChiTietThucDon;
		
		private EntityRef<HoaDon> _HoaDon;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(string value);
    partial void OnMaHDChanged();
    partial void OnBanChanging(string value);
    partial void OnBanChanged();
    partial void OnTenMonChanging(string value);
    partial void OnTenMonChanged();
    partial void OnSoLuongChanging(System.Nullable<short> value);
    partial void OnSoLuongChanged();
    partial void OnDonGiaChanging(string value);
    partial void OnDonGiaChanged();
    partial void OnTongCongChanging(System.Nullable<double> value);
    partial void OnTongCongChanged();
    partial void OnMaMonChanging(string value);
    partial void OnMaMonChanged();
    #endregion
		
		public ChiTietHoaDon()
		{
			this._Ban1 = default(EntityRef<Ban>);
			this._ChiTietThucDon = default(EntityRef<ChiTietThucDon>);
			this._HoaDon = default(EntityRef<HoaDon>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					if (this._HoaDon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ban", DbType="NVarChar(50)")]
		public string Ban
		{
			get
			{
				return this._Ban;
			}
			set
			{
				if ((this._Ban != value))
				{
					if (this._Ban1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBanChanging(value);
					this.SendPropertyChanging();
					this._Ban = value;
					this.SendPropertyChanged("Ban");
					this.OnBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMon", DbType="NVarChar(50)")]
		public string TenMon
		{
			get
			{
				return this._TenMon;
			}
			set
			{
				if ((this._TenMon != value))
				{
					this.OnTenMonChanging(value);
					this.SendPropertyChanging();
					this._TenMon = value;
					this.SendPropertyChanged("TenMon");
					this.OnTenMonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="SmallInt")]
		public System.Nullable<short> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="NChar(10)")]
		public string DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongCong", DbType="Float")]
		public System.Nullable<double> TongCong
		{
			get
			{
				return this._TongCong;
			}
			set
			{
				if ((this._TongCong != value))
				{
					this.OnTongCongChanging(value);
					this.SendPropertyChanging();
					this._TongCong = value;
					this.SendPropertyChanged("TongCong");
					this.OnTongCongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMon", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaMon
		{
			get
			{
				return this._MaMon;
			}
			set
			{
				if ((this._MaMon != value))
				{
					if (this._ChiTietThucDon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaMonChanging(value);
					this.SendPropertyChanging();
					this._MaMon = value;
					this.SendPropertyChanged("MaMon");
					this.OnMaMonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ban_ChiTietHoaDon", Storage="_Ban1", ThisKey="Ban", OtherKey="MaBan", IsForeignKey=true)]
		public Ban Ban1
		{
			get
			{
				return this._Ban1.Entity;
			}
			set
			{
				Ban previousValue = this._Ban1.Entity;
				if (((previousValue != value) 
							|| (this._Ban1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ban1.Entity = null;
						previousValue.ChiTietHoaDons.Remove(this);
					}
					this._Ban1.Entity = value;
					if ((value != null))
					{
						value.ChiTietHoaDons.Add(this);
						this._Ban = value.MaBan;
					}
					else
					{
						this._Ban = default(string);
					}
					this.SendPropertyChanged("Ban1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChiTietThucDon_ChiTietHoaDon", Storage="_ChiTietThucDon", ThisKey="MaMon", OtherKey="MaMon", IsForeignKey=true)]
		public ChiTietThucDon ChiTietThucDon
		{
			get
			{
				return this._ChiTietThucDon.Entity;
			}
			set
			{
				ChiTietThucDon previousValue = this._ChiTietThucDon.Entity;
				if (((previousValue != value) 
							|| (this._ChiTietThucDon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ChiTietThucDon.Entity = null;
						previousValue.ChiTietHoaDons.Remove(this);
					}
					this._ChiTietThucDon.Entity = value;
					if ((value != null))
					{
						value.ChiTietHoaDons.Add(this);
						this._MaMon = value.MaMon;
					}
					else
					{
						this._MaMon = default(string);
					}
					this.SendPropertyChanged("ChiTietThucDon");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HoaDon_ChiTietHoaDon", Storage="_HoaDon", ThisKey="MaHD", OtherKey="MaHD", IsForeignKey=true)]
		public HoaDon HoaDon
		{
			get
			{
				return this._HoaDon.Entity;
			}
			set
			{
				HoaDon previousValue = this._HoaDon.Entity;
				if (((previousValue != value) 
							|| (this._HoaDon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HoaDon.Entity = null;
						previousValue.ChiTietHoaDons.Remove(this);
					}
					this._HoaDon.Entity = value;
					if ((value != null))
					{
						value.ChiTietHoaDons.Add(this);
						this._MaHD = value.MaHD;
					}
					else
					{
						this._MaHD = default(string);
					}
					this.SendPropertyChanged("HoaDon");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietThucDon")]
	public partial class ChiTietThucDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaMon;
		
		private string _MaLoai;
		
		private string _TenMon;
		
		private System.Nullable<double> _DonGia;
		
		private EntitySet<ChiTietHoaDon> _ChiTietHoaDons;
		
		private EntityRef<LoaiThucDon> _LoaiThucDon;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaMonChanging(string value);
    partial void OnMaMonChanged();
    partial void OnMaLoaiChanging(string value);
    partial void OnMaLoaiChanged();
    partial void OnTenMonChanging(string value);
    partial void OnTenMonChanged();
    partial void OnDonGiaChanging(System.Nullable<double> value);
    partial void OnDonGiaChanged();
    #endregion
		
		public ChiTietThucDon()
		{
			this._ChiTietHoaDons = new EntitySet<ChiTietHoaDon>(new Action<ChiTietHoaDon>(this.attach_ChiTietHoaDons), new Action<ChiTietHoaDon>(this.detach_ChiTietHoaDons));
			this._LoaiThucDon = default(EntityRef<LoaiThucDon>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMon", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaMon
		{
			get
			{
				return this._MaMon;
			}
			set
			{
				if ((this._MaMon != value))
				{
					this.OnMaMonChanging(value);
					this.SendPropertyChanging();
					this._MaMon = value;
					this.SendPropertyChanged("MaMon");
					this.OnMaMonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoai", DbType="NChar(10)")]
		public string MaLoai
		{
			get
			{
				return this._MaLoai;
			}
			set
			{
				if ((this._MaLoai != value))
				{
					if (this._LoaiThucDon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaLoai = value;
					this.SendPropertyChanged("MaLoai");
					this.OnMaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMon", DbType="NVarChar(50)")]
		public string TenMon
		{
			get
			{
				return this._TenMon;
			}
			set
			{
				if ((this._TenMon != value))
				{
					this.OnTenMonChanging(value);
					this.SendPropertyChanging();
					this._TenMon = value;
					this.SendPropertyChanged("TenMon");
					this.OnTenMonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Float")]
		public System.Nullable<double> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChiTietThucDon_ChiTietHoaDon", Storage="_ChiTietHoaDons", ThisKey="MaMon", OtherKey="MaMon")]
		public EntitySet<ChiTietHoaDon> ChiTietHoaDons
		{
			get
			{
				return this._ChiTietHoaDons;
			}
			set
			{
				this._ChiTietHoaDons.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiThucDon_ChiTietThucDon", Storage="_LoaiThucDon", ThisKey="MaLoai", OtherKey="MaLoai", IsForeignKey=true)]
		public LoaiThucDon LoaiThucDon
		{
			get
			{
				return this._LoaiThucDon.Entity;
			}
			set
			{
				LoaiThucDon previousValue = this._LoaiThucDon.Entity;
				if (((previousValue != value) 
							|| (this._LoaiThucDon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiThucDon.Entity = null;
						previousValue.ChiTietThucDons.Remove(this);
					}
					this._LoaiThucDon.Entity = value;
					if ((value != null))
					{
						value.ChiTietThucDons.Add(this);
						this._MaLoai = value.MaLoai;
					}
					else
					{
						this._MaLoai = default(string);
					}
					this.SendPropertyChanged("LoaiThucDon");
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
		
		private void attach_ChiTietHoaDons(ChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.ChiTietThucDon = this;
		}
		
		private void detach_ChiTietHoaDons(ChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.ChiTietThucDon = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDon")]
	public partial class HoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHD;
		
		private string _MaNV;
		
		private System.Nullable<System.DateTime> _NgayBan;
		
		private System.Nullable<double> _TongTien;
		
		private EntitySet<ChiTietHoaDon> _ChiTietHoaDons;
		
		private EntityRef<NhanVien> _NhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(string value);
    partial void OnMaHDChanged();
    partial void OnMaNVChanging(string value);
    partial void OnMaNVChanged();
    partial void OnNgayBanChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayBanChanged();
    partial void OnTongTienChanging(System.Nullable<double> value);
    partial void OnTongTienChanged();
    #endregion
		
		public HoaDon()
		{
			this._ChiTietHoaDons = new EntitySet<ChiTietHoaDon>(new Action<ChiTietHoaDon>(this.attach_ChiTietHoaDons), new Action<ChiTietHoaDon>(this.detach_ChiTietHoaDons));
			this._NhanVien = default(EntityRef<NhanVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="NChar(10)")]
		public string MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayBan", DbType="Date")]
		public System.Nullable<System.DateTime> NgayBan
		{
			get
			{
				return this._NgayBan;
			}
			set
			{
				if ((this._NgayBan != value))
				{
					this.OnNgayBanChanging(value);
					this.SendPropertyChanging();
					this._NgayBan = value;
					this.SendPropertyChanged("NgayBan");
					this.OnNgayBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="Float")]
		public System.Nullable<double> TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this.OnTongTienChanging(value);
					this.SendPropertyChanging();
					this._TongTien = value;
					this.SendPropertyChanged("TongTien");
					this.OnTongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HoaDon_ChiTietHoaDon", Storage="_ChiTietHoaDons", ThisKey="MaHD", OtherKey="MaHD")]
		public EntitySet<ChiTietHoaDon> ChiTietHoaDons
		{
			get
			{
				return this._ChiTietHoaDons;
			}
			set
			{
				this._ChiTietHoaDons.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_HoaDon", Storage="_NhanVien", ThisKey="MaNV", OtherKey="MaNV", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._MaNV = value.MaNV;
					}
					else
					{
						this._MaNV = default(string);
					}
					this.SendPropertyChanged("NhanVien");
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
		
		private void attach_ChiTietHoaDons(ChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.HoaDon = this;
		}
		
		private void detach_ChiTietHoaDons(ChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.HoaDon = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiThucDon")]
	public partial class LoaiThucDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaLoai;
		
		private string _TenLoai;
		
		private EntitySet<ChiTietThucDon> _ChiTietThucDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLoaiChanging(string value);
    partial void OnMaLoaiChanged();
    partial void OnTenLoaiChanging(string value);
    partial void OnTenLoaiChanged();
    #endregion
		
		public LoaiThucDon()
		{
			this._ChiTietThucDons = new EntitySet<ChiTietThucDon>(new Action<ChiTietThucDon>(this.attach_ChiTietThucDons), new Action<ChiTietThucDon>(this.detach_ChiTietThucDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoai", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaLoai
		{
			get
			{
				return this._MaLoai;
			}
			set
			{
				if ((this._MaLoai != value))
				{
					this.OnMaLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaLoai = value;
					this.SendPropertyChanged("MaLoai");
					this.OnMaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoai", DbType="NVarChar(50)")]
		public string TenLoai
		{
			get
			{
				return this._TenLoai;
			}
			set
			{
				if ((this._TenLoai != value))
				{
					this.OnTenLoaiChanging(value);
					this.SendPropertyChanging();
					this._TenLoai = value;
					this.SendPropertyChanged("TenLoai");
					this.OnTenLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiThucDon_ChiTietThucDon", Storage="_ChiTietThucDons", ThisKey="MaLoai", OtherKey="MaLoai")]
		public EntitySet<ChiTietThucDon> ChiTietThucDons
		{
			get
			{
				return this._ChiTietThucDons;
			}
			set
			{
				this._ChiTietThucDons.Assign(value);
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
		
		private void attach_ChiTietThucDons(ChiTietThucDon entity)
		{
			this.SendPropertyChanging();
			entity.LoaiThucDon = this;
		}
		
		private void detach_ChiTietThucDons(ChiTietThucDon entity)
		{
			this.SendPropertyChanging();
			entity.LoaiThucDon = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNV;
		
		private string _TenNV;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private string _GioiTinh;
		
		private System.Nullable<decimal> _Luong;
		
		private string _HinhAnh;
		
		private EntitySet<QL_NguoiDung> _QL_NguoiDungs;
		
		private EntitySet<HoaDon> _HoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNVChanging(string value);
    partial void OnMaNVChanged();
    partial void OnTenNVChanging(string value);
    partial void OnTenNVChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnLuongChanging(System.Nullable<decimal> value);
    partial void OnLuongChanged();
    partial void OnHinhAnhChanging(string value);
    partial void OnHinhAnhChanged();
    #endregion
		
		public NhanVien()
		{
			this._QL_NguoiDungs = new EntitySet<QL_NguoiDung>(new Action<QL_NguoiDung>(this.attach_QL_NguoiDungs), new Action<QL_NguoiDung>(this.detach_QL_NguoiDungs));
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNV", DbType="NVarChar(50)")]
		public string TenNV
		{
			get
			{
				return this._TenNV;
			}
			set
			{
				if ((this._TenNV != value))
				{
					this.OnTenNVChanging(value);
					this.SendPropertyChanging();
					this._TenNV = value;
					this.SendPropertyChanged("TenNV");
					this.OnTenNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(3)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Luong", DbType="Money")]
		public System.Nullable<decimal> Luong
		{
			get
			{
				return this._Luong;
			}
			set
			{
				if ((this._Luong != value))
				{
					this.OnLuongChanging(value);
					this.SendPropertyChanging();
					this._Luong = value;
					this.SendPropertyChanged("Luong");
					this.OnLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnh", DbType="NVarChar(MAX)")]
		public string HinhAnh
		{
			get
			{
				return this._HinhAnh;
			}
			set
			{
				if ((this._HinhAnh != value))
				{
					this.OnHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._HinhAnh = value;
					this.SendPropertyChanged("HinhAnh");
					this.OnHinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_QL_NguoiDung", Storage="_QL_NguoiDungs", ThisKey="MaNV", OtherKey="MaNV")]
		public EntitySet<QL_NguoiDung> QL_NguoiDungs
		{
			get
			{
				return this._QL_NguoiDungs;
			}
			set
			{
				this._QL_NguoiDungs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_HoaDon", Storage="_HoaDons", ThisKey="MaNV", OtherKey="MaNV")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
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
		
		private void attach_QL_NguoiDungs(QL_NguoiDung entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_QL_NguoiDungs(QL_NguoiDung entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
	}
}
#pragma warning restore 1591
