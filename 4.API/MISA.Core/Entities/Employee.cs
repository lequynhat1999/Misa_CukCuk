﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    public class Employee : Base
    {
        #region Property
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        [Required]
        [CheckExist]
        [Name("Mã nhân viên")]
        public string EmployeeCode { get; set; }

        /// <summary>
        /// Họ
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Tên đệm và tên
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Họ và tên
        /// </summary>
        [Required]
        [Name("Họ và tên")]
        public string FullName { get; set; }

        /// <summary>
        /// Số giới tính
        /// </summary>
        public int? Gender { get; set; }

        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        [Required]
        [Name("Số điện thoại")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [Required]
        [CheckEmail]
        [Name("Email")]
        public string Email { get; set; }

        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Số CMND/Căn cước
        /// </summary>
        [Required]
        [Name("Số CMTND/Căn cước")]
        public string IdentityNumber { get; set; }

        /// <summary>
        /// Ngày cấp CMND/Căn cước
        /// </summary>
        public DateTime? IdentityDate { get; set; }

        /// <summary>
        /// Địa điểm cấp CMND/Căn cước
        /// </summary>
        public string IdentityPlace { get; set; }

        /// <summary>
        /// Ngày gia nhập công ty
        /// </summary>
        public DateTime? JoinDate { get; set; }

        /// <summary>
        /// Id phòng ban
        /// </summary>
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Tên phòng ban
        /// </summary>
        [NotMap]
        public string DepartmentName { get; set; }

        /// <summary>
        /// Id vị trí
        /// </summary>
        public Guid PositionId { get; set; }

        /// <summary>
        /// Tên chức vụ 
        /// </summary>
        [NotMap]
        public string PositionName { get; set; }

        /// <summary>
        /// Số của trạng thái công việc
        /// </summary>
        public int? WorkStatus { get; set; }

        /// <summary>
        /// Mã số thuế
        /// </summary>
        public string PersonalTaxCode { get; set; }

        /// <summary>
        /// Lương
        /// </summary>
        public int? Salary { get; set; }

        /// <summary>
        /// Tên giới tính
        /// </summary>
        //public string GenderName { get; set; }

        [NotMap]
        public List<string> ImportArrError { get; set; } = new List<string>();

        #endregion
    }
}
