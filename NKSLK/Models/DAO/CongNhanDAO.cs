﻿using NKSLK.Models.DTO;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NKSLK.Models.DAO
{
    public class CongNhanDAO
    {
        NKSLKModel db;
        public CongNhanDAO()
        {
            db = new NKSLKModel();
        }

        public IEnumerable<CongNhan> listCN(int pageNum, int pageSize) //, string maxp,string minp, int idcategory
        {

            string q = "select * from CongNhan";
            var lst = db.Database.SqlQuery<CongNhan>(q).ToPagedList<CongNhan>(pageNum, pageSize);
            return lst;
        }
        public void Delete(int id)
        {
            CongNhan congnhan = db.CongNhans.Find(id);
            if (congnhan != null)
            {
                db.CongNhans.Remove(congnhan);
                db.SaveChanges();
            }
        }

        public int Create(string name, DateTime? dob, bool gt, string phongban, string chucvu, string quequan,decimal luonghd , decimal luongbh)
        {

            CongNhan cn = new CongNhan();
            cn.MaCN = db.CongNhans.Max(i => i.MaCN) + 1;
            cn.HoTen = name;
            cn.NgaySinh = dob;
            cn.GioiTinh = gt;
            cn.PhongBan = phongban;
            cn.ChucVu = chucvu;
            cn.QueQuan = quequan;
            cn.LuongHD = luonghd;
            cn.LuongBaoHiem = luongbh;
            db.CongNhans.Add(cn);
            db.SaveChanges();
            return cn.MaCN;
        }
        public CongNhan getById(int id)
        {
            return db.CongNhans.Single(i => i.MaCN == id);
        }
        public void Edit(CongNhan tmp)
        {
            CongNhan cn = db.CongNhans.Find(tmp.MaCN);
            if (cn != null)
            {
                cn.HoTen = tmp.HoTen;
                cn.NgaySinh = tmp.NgaySinh;
                cn.GioiTinh = tmp.GioiTinh;
                cn.PhongBan = tmp.PhongBan;
                cn.ChucVu = tmp.ChucVu;
                cn.QueQuan = tmp.QueQuan;
                cn.LuongHD = tmp.LuongHD;
                cn.LuongBaoHiem = tmp.LuongBaoHiem;

                db.SaveChanges();

            }
        }
        public void Add(CongNhan cn)
        {
            db.CongNhans.Add(cn);
            db.SaveChanges();
        }
        //public Category getCategoryname(Products pro)
        //{
        //    return db.Category.Single(i => i.ID == pro.IDCATEGORY);
        //}
    }
}