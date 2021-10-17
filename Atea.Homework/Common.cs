using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Atea.Homework
{
    public class Common
    {
        public bool validateInputTypes(Input input)
        {
            string ftp = returnDataType(input.firstArgument);
            string stp = returnDataType(input.secondArgument);
            if (ftp.Equals(stp))
            {
                input.type = ftp;
                return true;
            }
            else
                return false;
        }
        private string returnDataType(dynamic input)
        {
            try
            {
                string type = string.Empty;
                if (Int32.TryParse(Convert.ToString(input), out int iresult))
                {
                    type = "int";
                }
                else if (decimal.TryParse(Convert.ToString(input), out decimal dresult))
                {
                    type = "decimal";
                }
                else if (char.TryParse(Convert.ToString(input), out char cresult))
                {
                    type = "string";
                }
                else
                {
                    type = "string";
                }
                return type;
            }
            catch (Exception ex)
            {
                return ex.Message + "error returnDataType Method";
            }
        }

        public string PostDataToApi(Entity entity)
        {
            try
            {
                using (var client = new HttpClient())
                {

                    using (var content = new StringContent(JsonConvert.SerializeObject(entity), System.Text.Encoding.UTF8, "application/json"))
                    {

                        HttpResponseMessage result = client.PostAsync("https://localhost:44379/Addition", content).Result;
                        if (result.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            return "Data has been saved into database sucessfully";
                        }
                        throw new Exception($"Failed to POST data: ({result.StatusCode})");
                    }
                }


            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
       
    }
}
