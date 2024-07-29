'use client';

import { useEffect, useState } from 'react';

export async function fetchMatters() {
  const res = await fetch('http://localhost:5296/matters');
  if (!res.ok) {
    throw new Error('Failed to fetch data');
  }
  const data = await res.json();
  return data;
}

export default function Home() {
  const [matters, setMatters] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    fetchMatters()
        .then(data => {
          setMatters(data);
          setLoading(false);
        })
        .catch(err => {
          setError(err);
          setLoading(false);
        });
  }, []);

  if (loading) return <p>Loading...</p>;
  if (error) return <p>{`Error: ${error.message}`}</p>;

  return (
      <div>
        <h1>Matters</h1>
        <ul>
          {matters.map(matter => (
              <li key={matter.id}>
                <h2>{matter.name}</h2>
                <p>Work Type: {matter.workTypeId}</p>
                <p>Status: {matter.status}</p>
                <p>Currency: {matter.currency}</p>
              </li>
          ))}
        </ul>
      </div>
  );
}