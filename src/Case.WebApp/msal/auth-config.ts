import { Configuration, PublicClientApplication } from '@azure/msal-browser';

export const msalConfig: Configuration = {
    auth: {
        clientId: `${process.env.NEXT_PUBLIC_AZURE_AD_CLIENT_ID}`,
        authority: `https://login.microsoftonline.com/${process.env.NEXT_PUBLIC_AZURE_AD_TENANT_ID}`,
        redirectUri: '/',
        postLogoutRedirectUri: "/"
    },
    system: {
        allowNativeBroker: false // Disables WAM Broker
    }
}

const msalInstance = new PublicClientApplication(msalConfig);

export { msalInstance };