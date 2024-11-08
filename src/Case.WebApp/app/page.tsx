'use client';

import { AuthenticatedTemplate, MsalProvider, UnauthenticatedTemplate, useMsal } from "@azure/msal-react";
import { msalInstance } from "@/msal/auth-config";

const SignInButton = () => {
    const { instance } = useMsal();

    return (
        <button onClick={() => {
            try {
                instance.loginRedirect();
            } catch (error) {
                console.error("Login failed", error);
            }
        }}>
            Sign In
        </button>
    );
}

const WelcomeUser = () => {
    const { accounts } = useMsal();
    const username = accounts.length > 0 ? accounts[0].username : "User";

    return <p>Welcome, {username}.</p>;
}

const SignOutButton = () => {
    const { instance } = useMsal();

    return (
        <button onClick={() => {
            try {
                instance.logoutRedirect();
            } catch (error) {
                console.error("Logout failed", error);
            }
        }}>
            Sign Out
        </button>
    );
}

export default function Home() {
    return (
        <MsalProvider instance={msalInstance}>
            <h1>Matters</h1>
            <AuthenticatedTemplate>
                <WelcomeUser />
                <SignOutButton />
            </AuthenticatedTemplate>
            <UnauthenticatedTemplate>
                <SignInButton />
            </UnauthenticatedTemplate>
        </MsalProvider>
    );
}