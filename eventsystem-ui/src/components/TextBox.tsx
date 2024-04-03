import React from "react";
import styles from "../styles/textBox.module.css";

interface TextBoxProps {
  content: string;
}

const TextBox: React.FC<TextBoxProps> = ({ content }) => {
  const parts = content.split(/<bold>(.*?)<\/bold>/);

  return (
    <div className={styles.Content}>
      {parts.map((part, index) => {
        if (index % 2 === 0) {
          // Render non-bold text as is
          return <span key={index}>{part}</span>;
        } else {
          // Render bold text wrapped in <strong> tags
          return <strong key={index}>{part}</strong>;
        }
      })}
    </div>
  );
};

export default TextBox;
