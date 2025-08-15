import { render, screen } from '@testing-library/react';
import { expect } from 'vitest';
import '@testing-library/jest-dom';
import About from './About';

test('renders About page heading', () => {
  render(<About />);
  expect(screen.getByRole('heading', { name: /about vijayasimha br/i })).toBeInTheDocument();
});

test('renders expertise section', () => {
  render(<About />);
  expect(screen.getByText(/cloud architecture, react, .net, azure, devops, microservices/i)).toBeInTheDocument();
});

test('renders LinkedIn link', () => {
  render(<About />);
  expect(screen.getByRole('link', { name: /vijayasimha br/i })).toHaveAttribute('href', expect.stringContaining('linkedin.com/in/vijayasimhabr'));
});