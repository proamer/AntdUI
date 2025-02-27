// COPYRIGHT (C) Tom. ALL RIGHTS RESERVED.
// THE AntdUI PROJECT IS AN WINFORM LIBRARY LICENSED UNDER THE Apache-2.0 License.
// LICENSED UNDER THE Apache License, VERSION 2.0 (THE "License")
// YOU MAY NOT USE THIS FILE EXCEPT IN COMPLIANCE WITH THE License.
// YOU MAY OBTAIN A COPY OF THE LICENSE AT
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN WRITING, SOFTWARE
// DISTRIBUTED UNDER THE LICENSE IS DISTRIBUTED ON AN "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED.
// SEE THE LICENSE FOR THE SPECIFIC LANGUAGE GOVERNING PERMISSIONS AND
// LIMITATIONS UNDER THE License.
// GITEE: https://gitee.com/antdui/AntdUI
// GITHUB: https://github.com/AntdUI/AntdUI
// CSDN: https://blog.csdn.net/v_132
// QQ: 17379620

using System.Collections.Generic;

namespace AntdUI
{
    partial class SvgDb
    {
        static SvgDb()
        {
            var datas = Properties.Resources.Custom.Split('|');
            Custom = new Dictionary<string, string>(datas.Length);
            //foreach (string s in datas)
            //{
            //    var i = s.IndexOf(":");
            //    Custom.Add(s.Substring(0, i), s.Substring(i + 1));
            //}
            foreach (string s in datas)
            {
                var i = s.IndexOf(":");
                var key = s.Substring(0, i);
                var value = s.Substring(i + 1);

                // ตรวจสอบว่ามี Key นี้อยู่แล้วหรือไม่
                if (!Custom.ContainsKey(key))
                {
                    Custom.Add(key, value);
                }
                else
                {
                    // กรณีมี Key ซ้ำ สามารถเลือกทำอย่างใดอย่างหนึ่งต่อไปนี้:
                    // 1. ข้ามไปเลย
                    // continue;

                    // 2. เขียนทับค่าเดิม
                    Custom[key] = value;

                    // 3. แจ้งเตือนเพื่อให้รู้ว่ามี Key ซ้ำ (สำหรับ Debug)
                    // Console.WriteLine($"Duplicate key found: {key}");
                }
            }
        }
        public static Dictionary<string, string> Custom;
    }
}
