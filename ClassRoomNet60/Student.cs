using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassRoomNet60;

public class Student {
    public string Name { get; set; }

    public int BirthMonth;

    public int BirthDay;

    public Student(string name, int birthMonth, int birthDay) {
        Name = name;
        BirthMonth = birthMonth;
        BirthDay = birthDay;
    }

}

