namespace Week1_Homework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(客戶銀行資訊MetaData))]
    public partial class 客戶銀行資訊
    {
    }
    
    public partial class 客戶銀行資訊MetaData
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int 客戶Id { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required(ErrorMessage ="請輸入銀行名稱")]
        public string 銀行名稱 { get; set; }
        [Required(ErrorMessage = "請輸入銀行代碼")]
        public int 銀行代碼 { get; set; }
        [Required(ErrorMessage = "請輸入分行代碼")]
        public Nullable<int> 分行代碼 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required(ErrorMessage = "請輸入帳戶名稱")]
        public string 帳戶名稱 { get; set; }
        
        [StringLength(20, ErrorMessage="欄位長度不得大於 20 個字元")]
        [Required(ErrorMessage = "帳戶號碼")]
        public string 帳戶號碼 { get; set; }
        [Required]
        public bool is刪除 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }
    }
}
