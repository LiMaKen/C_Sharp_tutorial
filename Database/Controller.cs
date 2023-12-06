using System;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
namespace Database.controller;
interface IControler
{
    bool IsStudentId(string studentId);
    bool IsBirth(string birth);
    bool IsName(string name);
    bool IsEmail(string email);
    bool IsPhone(string phone);
    bool IsSubjectId(string idSubject);
    bool IsCourseId(string idCourse);
    bool IsTranScriptId(string idTranScript);
}
class Controler : IControler
{
    public bool IsBirth(string birth)
    {
        // thang 01-09, 10 11 12
        // ngay 01-09, 10-19, 20-29, 30-31
        var pattern = @"^(0[0-9]|1[0-9]|2[0-9]|3[0-1])/(0[1-9]|1[0-2])/\d{4}$";
        var result = new Regex(pattern);
        return result.IsMatch(birth);
    }

    public bool IsCourseId(string idCourse)
    {
        throw new NotImplementedException();
    }

    public bool IsEmail(string email)
    {
        var pattern = @"^[a-z0-9.-_]+\@[a-z0-9]+\.[a-z]{2,4}$";
        var result = new Regex(pattern, RegexOptions.IgnoreCase);
        return result.IsMatch(email);
    }

    public bool IsName(string fullName)
    {
        var pattern = @"^[a-z ]{1,40}$";
        var result = new Regex(pattern, RegexOptions.IgnoreCase);
        return result.IsMatch(fullName);
    }

    public bool IsPhone(string phone)
    {
        var pattern = @"^(03|08|09)\d{8}$";
        var result = new Regex(pattern);
        return result.IsMatch(phone);
    }

    public bool IsStudentId(string studentId)
    {
        var pattern = @"^B\d{2}[A-Z]{4}\d{3}$";
        var result = new Regex(pattern);
        return result.IsMatch(studentId);
    }

    public bool IsSubjectId(string idSubject)
    {
        var pattern = @"^1[0-9]{4}$";
        var result = new Regex(pattern);
        return result.IsMatch(idSubject);
    }

    public bool IsTranScriptId(string idTranScript)
    {
        throw new NotImplementedException();
    }
}