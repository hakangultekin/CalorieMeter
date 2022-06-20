using CaloriMeter.DAL.Repositories;
using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.BLL.Services
{
    public class UserService
    {
        UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }

        /// <summary>
        /// Kullanıcı adı ve şifresi uyan kullanıcı varsa kullanıcıyı döndürür. Hatalı bilgi verildiyse null dönüş yapar.
        /// </summary>
        /// <param name="username">kullanıcı adı</param>
        /// <param name="password">şifre</param>
        /// <returns></returns>
        public User CheckLogin(string username, string password)
        {
            return userRepository.CheckLogin(username, password);
        }

        /// <summary>
        /// Verilen ID'ye ait kullanıcıyı döndürür.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUserById(int id)
        {
            return userRepository.GetUserById(id);
        }

        /// <summary>
        /// Bütün kullanıcıları döndürür.
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllUsers()
        {
            return userRepository.GetAllUsers();
        }

        /// <summary>
        /// Pasif durumdaki kullanıcıları döndürür.
        /// </summary>
        /// <returns></returns>
        public List<User> GetPasiveUsers()
        {
            return userRepository.GetPasiveUsers();
        }

        /// <summary>
        /// Kullanıcıyı aktif eder.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool UserActivate(int id)
        {
            return userRepository.UserActivate(id);
        }

        /// <summary>
        /// Kullanıcıyı deaktif eder.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool UserDeActivate(int id)
        {
            return userRepository.UserDeActivate(id);
        }

        /// <summary>
        /// Kullanıcı adı ve soyadına göre arama yapar
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public List<User> FindUser(string word)
        {
            return userRepository.FindUser(word);
        }

        /// <summary>
        /// Yeni kullanıcı ekler.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Insert(User entity)
        {
            CheckRequired(entity);
            CheckEmailValid(entity.UserName);
            return userRepository.Insert(entity);
        }

        /// <summary>
        /// Verilen kullanıcının bilgilerini günceller.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(User entity)
        {
            CheckRequired(entity);
            return userRepository.Update(entity);
        }

        /// <summary>
        /// ID'si verilen kullanıcının şifresini değiştirir.
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool ChangePassword(int userid, string password)
        {
            if (userid <= 0) throw new Exception("UserID 0'dan büyük olmalı.");
            if (string.IsNullOrWhiteSpace(password)) throw new Exception("Şifre alanı boş olamaz.");
            if (password.Length < 6) throw new Exception("Şifre en az 6 hane olmalıdır.");

            return userRepository.ChangePassword(userid, password);
        }

        void CheckRequired(User user)
        {
            if (string.IsNullOrEmpty(user.Name)) throw new Exception("İsim boş olamaz.");
            if (string.IsNullOrEmpty(user.LastName)) throw new Exception("Soyad alanı boş olamaz.");
            if (string.IsNullOrEmpty(user.UserName)) throw new Exception("Username alanı boş olamaz.");
            if (string.IsNullOrEmpty(user.Password)) throw new Exception("Şifre alanı boş olamaz.");
            if (string.IsNullOrWhiteSpace(user.Height.ToString()) || string.IsNullOrWhiteSpace(user.Weight.ToString())) throw new Exception("Boy ve kilo alanlarını giriniz.");
            if (user.Age < 18) throw new Exception("Kullanıcı 18 yaşından büyük olmalıdır.");
        }

        void CheckEmailValid(string value)
        {
            if (!value.Contains("@") || !value.Contains(".")) throw new Exception("Email adresi geçersiz.");
        }
    }
}
