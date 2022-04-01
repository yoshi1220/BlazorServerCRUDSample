using BlazorServerCRUDSample.Data;
using BlazorServerCRUDSample.Data.Models;
using BlazorServerCRUDSample.Repositories;
using System;
using System.Collections.Generic;

namespace BlazorServerCRUDSample.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(User entity)
        {
            _userRepository.Add(entity);
        }

        public User Get(int id)
        {
            return _userRepository.Get(id);
        }

        /// <summary>
        /// ユーザーデータを全件取得
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public void Remove(int id)
        {
            _userRepository.Remove(id);
        }

        public void Update(User entity)
        {
            _userRepository.Update(entity);
        }

    }
}
