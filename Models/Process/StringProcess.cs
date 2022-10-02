namespace Net2Demo.Models.Process;

public class StringProcess
{
    public string RemoveRemaningWhiteSpace(string strInput)
    {
        string strResult = "";
        //Viet code de xu ly theo yeu cau cua bai toan
        //xoa bo cac khoang trang o dau va cuoi chuoi
        strInput = strInput.Trim()
        //Xoa bo cac khoang trang con thua trong chuoi
        
        while(int index = strInput.Index0f(" ")>0)
        {
            strInput = strInput.Replace("  ", " ");
        }
        strResult = strInput;
        return strResult;
    }

    //public kieu du lieu tra ve ten phuong thuc ( tham so)

     public string LowerToUpper(string input)
    {
     string strResult ="";
     strResult = strResult.ToUpper();
     return strResult;
    }

     public string UpperToLower(string strInput)
    {
      string strResult ="";
      strResult = strResult.ToLower();
      return strResult;
    }

    public string CapitalizeOneFirstCharacter(string input)
    {
    return input.Substring(0, 1).ToUpper() + input.Substring(1);
    }

    public string CapitalizeFirstCharacter(string input)
    {
    string[] arr = input.Split(" ");
    string strResult = "";

    for (int i = 0; i < arr.Length; i++)
      {
      strResult += arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1) + " ";
      }

    return strResult;
    }

    public string RemoveVietNameseAcccents(string input)
    {
    string[] arr1 = new string[] { "aAeEoOuUiIdDyY" };
    string[] arr2 = new string[] { "áàạảãâấầậẩẫăắằặẳẵ", "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", "éèẹẻẽêếềệểễ", "ÉÈẸẺẼÊẾỀỆỂỄ", "óòọỏõôốồộổỗơớờợởỡ", "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", "úùụủũưứừựửữ", "ÚÙỤỦŨƯỨỪỰỬỮ", "íìịỉĩ", "ÍÌỊỈĨ", "đ", "Đ", "ýỳỵỷỹ", "ÝỲỴỶỸ" };

    for (int i = 1; i < arr2.Length; i++)
      {
      for (int j = 0; j < arr2[i].Length; j++)
        {
        input = input.Replace(arr2[i][j], arr1[0][i - 1]);
        }
      }

    return input;
    }

}