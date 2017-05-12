namespace Week1_Homework.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人 : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var db = new 客戶資料Entities();
            if (this.Id == 0) 
            {
                //create data
                if (db.客戶聯絡人.Where(p => p.客戶Id == this.客戶Id && p.Email == this.Email).Any())
                {
                    yield return new ValidationResult("Email 已存在!!", new string[] { "Email"});
                }
            }
            else
            {
                //update data
                if (db.客戶聯絡人.Where(p => p.客戶Id == this.客戶Id &&  p.Id !=  this.Id && p.Email == this.Email).Any())
                {
                    yield return new ValidationResult("Email 已存在!!", new string[] { "Email" });
                }
            }

            yield return ValidationResult.Success;
        }
    }

    public partial class 客戶聯絡人MetaData
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int 客戶Id { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required(ErrorMessage ="請輸入職稱")]
        public string 職稱 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
         [Required(ErrorMessage = "請輸入姓名")]
        public string 姓名 { get; set; }
        
        [StringLength(250, ErrorMessage="欄位長度不得大於 250 個字元")]
        [Required(ErrorMessage = "請輸入Email")]
        [EmailAddress(ErrorMessage = "不合法的Email格式")]
        public string Email { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required(ErrorMessage = "請輸入手機")]
        [RegularExpression(@"\d{4}-\d{6}",ErrorMessage ="手機號碼格式必為09xx-xxxxxx")]
        public string 手機 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required(ErrorMessage = "請輸入電話")]
        public string 電話 { get; set; }
        [Required]
        public bool is刪除 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }
    }
}
