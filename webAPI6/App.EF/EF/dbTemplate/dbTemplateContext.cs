using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App.EF.EF.dbTemplate
{
    public partial class dbTemplateContext : DbContext
    {
        public dbTemplateContext()
        {
        }

        public dbTemplateContext(DbContextOptions<dbTemplateContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAccessLog> TblAccessLog { get; set; } = null!;
        public virtual DbSet<TblBusinessUnit> TblBusinessUnit { get; set; } = null!;
        public virtual DbSet<TblFunction> TblFunction { get; set; } = null!;
        public virtual DbSet<TblFunctionOnBu> TblFunctionOnBu { get; set; } = null!;
        public virtual DbSet<TblFunctionOnGroup> TblFunctionOnGroup { get; set; } = null!;
        public virtual DbSet<TblLoginLog> TblLoginLog { get; set; } = null!;
        public virtual DbSet<TblSample> TblSample { get; set; } = null!;
        public virtual DbSet<TblUser> TblUser { get; set; } = null!;
        public virtual DbSet<TblUserGroup> TblUserGroup { get; set; } = null!;
        public virtual DbSet<TblUserOnGroup> TblUserOnGroup { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=dbTemplate;Trusted_Connection=False;user id=sa;password=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAccessLog>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("tblAccessLog");

                entity.Property(e => e.CId).HasColumnName("cID");

                entity.Property(e => e.CActionName)
                    .HasMaxLength(50)
                    .HasColumnName("cActionName")
                    .HasComment("{\r\n  \"isquery\":1,\r\n  \"isRequire\":1,\r\n  \"columnDesc\":\"動作名稱\"\r\n}");

                entity.Property(e => e.CApiname)
                    .HasMaxLength(50)
                    .HasColumnName("cAPIName")
                    .HasComment("API");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立日期");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者Id");

                entity.Property(e => e.CFunctionId)
                    .HasColumnName("cFunctionID")
                    .HasComment("{\r\n  \"isquery\":1,\r\n  \"type\":\"dropdownlist\",\r\n  \"options\":[{\"text\":\"功能1\",\"value\":\"1\"},{\"text\":\"功能2\",\"value\":\"2\"},{\"text\":\"功能3\",\"value\":\"3\"}],\r\n  \"columnDesc\":\"功能\"\r\n}");

                entity.Property(e => e.CIp)
                    .HasMaxLength(50)
                    .HasColumnName("cIP")
                    .HasComment("IP");

                entity.Property(e => e.CRemark)
                    .HasMaxLength(500)
                    .HasColumnName("cRemark")
                    .HasComment("備註");

                entity.Property(e => e.CRequest)
                    .HasColumnName("cRequest")
                    .HasComment("請求參數");

                entity.Property(e => e.CUpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdateDT")
                    .HasComment("更新日期");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者Id");

                entity.Property(e => e.CUrl)
                    .HasMaxLength(200)
                    .HasColumnName("cUrl")
                    .HasComment("URL");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");
            });

            modelBuilder.Entity<TblBusinessUnit>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("tblBusinessUnit");

                entity.HasComment("企業主檔");

                entity.Property(e => e.CId)
                    .HasColumnName("cID")
                    .HasComment("BUID");

                entity.Property(e => e.CBucode)
                    .HasMaxLength(20)
                    .HasColumnName("cBUCode")
                    .HasComment("BU代碼");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT");

                entity.Property(e => e.CCreator).HasColumnName("cCreator");

                entity.Property(e => e.CDescription)
                    .HasMaxLength(200)
                    .HasColumnName("cDescription")
                    .HasComment("說明");

                entity.Property(e => e.CName)
                    .HasMaxLength(50)
                    .HasColumnName("cName")
                    .HasComment("BU名稱");

                entity.Property(e => e.CPlatformIsSupport)
                    .HasColumnName("cPlatformIsSupport")
                    .HasComment("是否支援");

                entity.Property(e => e.CRemark)
                    .HasMaxLength(500)
                    .HasColumnName("cRemark")
                    .HasComment("備註");

                entity.Property(e => e.CStatus)
                    .HasColumnName("cStatus")
                    .HasComment("狀態");

                entity.Property(e => e.CType)
                    .HasColumnName("cType")
                    .HasComment("1 平台 2 商戶");

                entity.Property(e => e.CUpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdateDT");

                entity.Property(e => e.CUpdator).HasColumnName("cUpdator");

                entity.Property(e => e.CUserLimit)
                    .HasColumnName("cUserLimit")
                    .HasComment("使用者上限");
            });

            modelBuilder.Entity<TblFunction>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("tblFunction");

                entity.HasComment("單元(已審核)");

                entity.Property(e => e.CId)
                    .ValueGeneratedNever()
                    .HasColumnName("cID")
                    .HasComment("模組編號");

                entity.Property(e => e.CCompetenceType)
                    .HasColumnName("cCompetenceType")
                    .HasComment("(0:是單元, 1:新增, 2:修改, 3:檢視, 4:刪除, 5:審核)");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立日期時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CCssStyle)
                    .HasMaxLength(50)
                    .HasColumnName("cCssStyle")
                    .HasComment("後台CSS樣式名稱");

                entity.Property(e => e.CFlowId)
                    .HasColumnName("cFlowID")
                    .HasComment("審查流程ID");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("緩刪除(0:未刪除, 1:已刪除)");

                entity.Property(e => e.CIsMenu)
                    .HasColumnName("cIsMenu")
                    .HasComment("是否為後台目錄(0:否, 1:是)");

                entity.Property(e => e.CMenuIndex)
                    .HasColumnName("cMenuIndex")
                    .HasComment("前台及後台目錄索引值(排序由小到大)");

                entity.Property(e => e.CName)
                    .HasMaxLength(20)
                    .HasColumnName("cName")
                    .HasComment("模組名稱");

                entity.Property(e => e.CPageUrl)
                    .HasMaxLength(200)
                    .HasColumnName("cPageUrl")
                    .HasComment("功能頁面");

                entity.Property(e => e.CParentId)
                    .HasColumnName("cParentID")
                    .HasComment("父模組編號");

                entity.Property(e => e.CStatus)
                    .HasColumnName("cStatus")
                    .HasComment("狀態(0:停用, 1:啟用)");

                entity.Property(e => e.CUpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdateDT")
                    .HasComment("修改日期時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("修改者");
            });

            modelBuilder.Entity<TblFunctionOnBu>(entity =>
            {
                entity.HasKey(e => new { e.CBuid, e.CFunctionId });

                entity.ToTable("tblFunctionOnBU");

                entity.HasComment("模組功能管理(對應企業)");

                entity.Property(e => e.CBuid).HasColumnName("cBUID");

                entity.Property(e => e.CFunctionId).HasColumnName("cFunctionID");

                entity.Property(e => e.CStatus).HasColumnName("cStatus");
            });

            modelBuilder.Entity<TblFunctionOnGroup>(entity =>
            {
                entity.HasKey(e => new { e.CUserGroupId, e.CFunctionId })
                    .HasName("PK_tblFunctionOnRole");

                entity.ToTable("tblFunctionOnGroup");

                entity.Property(e => e.CUserGroupId)
                    .HasColumnName("cUserGroupID")
                    .HasComment("使用者群組編號");

                entity.Property(e => e.CFunctionId)
                    .HasColumnName("cFunctionID")
                    .HasComment("功能編號");
            });

            modelBuilder.Entity<TblLoginLog>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK_tblLoginHistory");

                entity.ToTable("tblLoginLog");

                entity.Property(e => e.CId).HasColumnName("cID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立日期");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者Id");

                entity.Property(e => e.CIp)
                    .HasMaxLength(50)
                    .HasColumnName("cIP");

                entity.Property(e => e.CUpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdateDT")
                    .HasComment("更新日期");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者Id");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");

                entity.Property(e => e.CUserToken)
                    .HasMaxLength(500)
                    .HasColumnName("cUserToken");
            });

            modelBuilder.Entity<TblSample>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK_tblTemplate");

                entity.ToTable("tblSample");

                entity.Property(e => e.CId)
                    .ValueGeneratedNever()
                    .HasColumnName("cId")
                    .HasComment("Key");

                entity.Property(e => e.CDescription)
                    .HasMaxLength(500)
                    .HasColumnName("cDescription")
                    .HasComment("{\r\n  \"isquery\":0,\r\n  \"isRequire\":1,\r\n  \"columnDesc\":\"必填範例\"\r\n}");

                entity.Property(e => e.CQueryBox)
                    .HasMaxLength(100)
                    .HasColumnName("cQueryBox")
                    .HasComment("{\r\n  \"isquery\":1,\r\n  \"columnDesc\":\"查詢範例\"\r\n}");

                entity.Property(e => e.CStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cStartDate")
                    .HasComment("日期範例");

                entity.Property(e => e.CTitle)
                    .HasMaxLength(50)
                    .HasColumnName("cTitle")
                    .HasComment("文字框範例");

                entity.Property(e => e.CType)
                    .HasMaxLength(10)
                    .HasColumnName("cType")
                    .HasComment("{\r\n  \"isquery\":1,\r\n  \"isRequire\":1,\r\n  \"type\":\"dropdownlist\",\r\n  \"options\":[{\"text\":\"功能1\",\"value\":\"T1\"},{\"text\":\"功能2\",\"value\":\"T2\"},{\"text\":\"功能3\",\"value\":\"T3\"}],\r\n  \"columnDesc\":\"下拉範例\"\r\n}");

                entity.Property(e => e.CType2)
                    .HasMaxLength(100)
                    .HasColumnName("cType2")
                    .HasComment("{\r\n  \"isquery\":0,\r\n  \"isRequire\":1,\r\n  \"type\":\"dropdownlist\",\r\n  \"options\":[{\"text\":\"B功能1\",\"value\":\"T1\"},{\"text\":\"B功能2\",\"value\":\"T2\"},{\"text\":\"B功能3\",\"value\":\"T3\"}],\r\n  \"columnDesc\":\"下拉範例2\"\r\n}");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.CUserId);

                entity.ToTable("tblUser");

                entity.HasComment("使用者");

                entity.Property(e => e.CUserId)
                    .HasColumnName("cUserID")
                    .HasComment("使用者編號編號");

                entity.Property(e => e.CAccount)
                    .HasMaxLength(100)
                    .HasColumnName("cAccount")
                    .HasComment("cAccount、cAccount2都不可重複");

                entity.Property(e => e.CAgentUnit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cAgentUnit")
                    .HasComment("代理單位");

                entity.Property(e => e.CBuid)
                    .HasColumnName("cBUID")
                    .HasComment("BU");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立日期時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CIsDelete)
                    .HasColumnName("cIsDelete")
                    .HasComment("緩刪除(0:未刪除, 1:已刪除)");

                entity.Property(e => e.CIsDeptManager)
                    .HasColumnName("cIsDeptManager")
                    .HasComment("是否為單位最高權限(0:否, 1:是)");

                entity.Property(e => e.CMail)
                    .HasMaxLength(254)
                    .HasColumnName("cMail")
                    .HasComment("信箱");

                entity.Property(e => e.CPassword)
                    .HasColumnName("cPassword")
                    .HasComment("密碼");

                entity.Property(e => e.CStatus)
                    .HasColumnName("cStatus")
                    .HasComment("狀態 0:停用 1:啟用");

                entity.Property(e => e.CUpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdateDT")
                    .HasComment("更新日期時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");

                entity.Property(e => e.CUserName)
                    .HasMaxLength(50)
                    .HasColumnName("cUserName")
                    .HasComment("使用者名稱");
            });

            modelBuilder.Entity<TblUserGroup>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("tblUserGroup");

                entity.HasComment("使用者群組");

                entity.Property(e => e.CId)
                    .HasColumnName("cID")
                    .HasComment("使用者群組編號");

                entity.Property(e => e.CBuid).HasColumnName("cBUID");

                entity.Property(e => e.CCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cCreateDT")
                    .HasComment("建立日期時間");

                entity.Property(e => e.CCreator)
                    .HasColumnName("cCreator")
                    .HasComment("建立者");

                entity.Property(e => e.CName)
                    .HasMaxLength(100)
                    .HasColumnName("cName")
                    .HasComment("群組名稱");

                entity.Property(e => e.CStatus)
                    .HasColumnName("cStatus")
                    .HasComment("狀態(0:停用, 1:啟用)");

                entity.Property(e => e.CUpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cUpdateDT")
                    .HasComment("更新日期時間");

                entity.Property(e => e.CUpdator)
                    .HasColumnName("cUpdator")
                    .HasComment("更新者");
            });

            modelBuilder.Entity<TblUserOnGroup>(entity =>
            {
                entity.HasKey(e => new { e.CUserId, e.CUserGroupId });

                entity.ToTable("tblUserOnGroup");

                entity.Property(e => e.CUserId).HasColumnName("cUserID");

                entity.Property(e => e.CUserGroupId).HasColumnName("cUserGroupID");

                entity.Property(e => e.CStatus).HasColumnName("cStatus");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
