import {
  Configuration,
  LogLevel,
  PopupRequest,
  PublicClientApplication,
} from "@azure/msal-browser";

// Config object to be passed to Msal on creation
export const msalConfig: Configuration = {
  auth: {
    clientId: "5ca2b64f-7b3e-467d-a864-0896e8f9b365",
    authority: "https://login.microsoftonline.com/6a7d066a-018e-4ac2-8adc-26672ade352a", // common (multi-tenant app) or your tenantId
    redirectUri: "http://localhost:3000",
    postLogoutRedirectUri: "/",
  },
  system: {
    allowNativeBroker: false, // Disables WAM Broker
    loggerOptions: {
      loggerCallback: (level, message, containsPii) => {
        if (containsPii) {
          return;
        }
        switch (level) {
          case LogLevel.Error:
            console.error(message);
            return;
          case LogLevel.Info:
            // console.info(message);
            return;
          case LogLevel.Verbose:
            console.debug(message);
            return;
          case LogLevel.Warning:
            console.warn(message);
            return;
          default:
            return;
        }
      },
    },
  },
  cache: {
    cacheLocation: "sessionStorage", // This configures where your cache will be stored
    storeAuthStateInCookie: false, // Set this to "true" if you are having issues on IE11 or Edge
  },
};

// Add here scopes for id token to be used at MS Identity Platform endpoints.
export const loginRequest: PopupRequest = {
  scopes: ["User.Read"],
};

// Add here the endpoints for MS Graph API services you would like to use.
export const graphConfig = {
  graphMeEndpoint: "https://graph.microsoft.com/v1.0/me",
  graphMePhotoEndpoint:
    "https://graph.microsoft.com/v1.0/me/photos/48x48/$value",
};

export const msalInstance = new PublicClientApplication(msalConfig);
