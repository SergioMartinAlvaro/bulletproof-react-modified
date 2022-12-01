export type AuthUser = {
    username: string;
    password: string;
  };
  
  export type UserResponse = {
    jwt: string;
    user: AuthUser;
  };
  