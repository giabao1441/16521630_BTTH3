﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Hoas.Models;
using LoaiHoa;

namespace Hoas.Data
{
    public class HoaDatabase
    {
        //lấy thư mục lưu trữ csdl trên hệ thống
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool createDatabase()
        {
            try
            {
                //tạo csdl
                //using (var connection = new
                // SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                //{
                //    //tạo 2 bang
                //    connection.CreateTable<Loaihoa>();
                //    connection.CreateTable<Hoa>();
                //    return true;
                //}

                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.CreateTable<Loaihoa>();
                    connection.CreateTable<Hoa>();
                    return true;

                }
            }
            catch (SQLiteException ex)
            {
                //Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public bool InsertLoaiHoa(Loaihoa loai)
        {
            try
            {
                //using (var connection = new
                //    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                //{
                //    connection.Insert(loai);
                //    return true;
                //}

                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(loai);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //   Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public List<Loaihoa> selectLoaihoa()
        {
            try
            {
                using (var connection = new SQLiteConnection
                    (System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<Loaihoa>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                //Log.Info("SQLiteEx", ex.Message);
                return null;
            }
        }
        //Xử lý Thêm Hoa
        public bool InsertHoa(Hoa h)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(h);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //   Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public List<Hoa> selecthoa()
        {
            try
            {
                using (var connection = new SQLiteConnection
                    (System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<Hoa>().ToList();
                }
            }
            catch (SQLiteException ex)
            {

                return null;
            }
        }
    }
}