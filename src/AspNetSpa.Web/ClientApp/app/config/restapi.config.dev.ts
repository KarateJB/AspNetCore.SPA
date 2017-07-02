
export class RestapiConfig {
  private REST_ROOT_URL: string = "http://localhost:54321/";
  public getBooksUri : string = this.REST_ROOT_URL.concat("api/Prod/GetBooks/");
};
