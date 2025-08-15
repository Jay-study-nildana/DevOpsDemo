# Azure App Service: Free Tier (F1) vs Basic B1 Tier

This document summarizes the key differences, limitations, and best practices for deploying web apps using Azure App Service’s Free (F1) and Basic (B1) hosting plans. This is based on practical experience and platform documentation as of August 2025.

---

## Free Tier (F1)

**Overview:**  
- Designed for learning, quick demos, and very lightweight prototypes.
- No cost, but strict resource and app limits.

**Key Features & Limits:**
- **Maximum Web Apps:**  
  - **1 web app per region per subscription.**
  - Attempting to create more than one web app in the same region and subscription will result in an error:
    > "Cannot create more than 1 free web app in this region."
- **Resources:**  
  - Shared CPU and RAM with other tenants.
  - 1 GB memory.
  - 1 GB storage.
- **Performance:**  
  - Not suited for production workloads.
  - Apps may be stopped or paused at any time by Azure.
  - Cold starts and slow performance are common.
- **Scaling:**  
  - No scaling (cannot add more instances).
- **Custom Domain Support:**  
  - No support for custom domains or SSL for custom domains.
- **Always On Feature:**  
  - Not available; apps may sleep after a period of inactivity.

**Use Cases:**  
- Training, learning, demos.
- Very basic apps with no need for reliability or performance.

---

## Basic Tier (B1)

**Overview:**  
- Entry-level paid plan suitable for development, small apps, and classroom/demo use.
- Low cost, much greater flexibility and reliability.

**Key Features & Limits:**
- **Maximum Web Apps:**  
  - **Multiple web apps per App Service plan.**
  - No hard limit on the number of apps; limited only by available resources (CPU, memory, disk).
  - You pay for the App Service plan, not per app—so you can host many apps for no extra cost.
- **Resources:**  
  - Dedicated 1 CPU core.
  - 1.75 GB RAM.
  - 10 GB storage.
- **Performance:**  
  - Apps run reliably, no arbitrary shutdowns.
  - Suitable for classroom, dev, and basic production workloads.
- **Scaling:**  
  - Manual scaling: can increase instance count for higher availability.
- **Custom Domain Support:**  
  - Supported, including SSL for custom domains.
- **Always On Feature:**  
  - Available, keeping apps running even during inactivity.

**Use Cases:**  
- Development, staging, and low-traffic production apps.
- Classroom, student demos, and multi-app teaching setups.

---

## Transitioning from Free to Basic B1

- **Why Upgrade?**
  - To host more than one web app per region/subscription.
  - To avoid resource and reliability limitations.
  - To access features like custom domains and Always On.
- **How to Upgrade:**
  - In the Azure Portal, change the App Service plan pricing tier from Free (F1) to Basic (B1).
  - All existing web apps in the plan will inherit the new capabilities.
  - You can then create additional web apps under the same plan without extra cost.

---

## FAQ

- **Can I host multiple web apps for free?**
  - No, only one per region/subscription in Free tier.
- **Will my costs increase if I add more apps to B1?**
  - No, you pay for the plan, not per app; adding more apps only affects performance if resources are exhausted.
- **Is B1 suitable for student/classroom demos?**
  - Yes, it’s ideal for hosting multiple low-traffic apps with good reliability.

---

## Best Practices

- Use Free tier only for very simple, single-app demos.
- For teaching, dev, or multiple apps, use Basic B1 for better flexibility and reliability.
- Monitor resource usage if you host many apps on one B1 plan; scale up or out if needed.

---

*Last updated: August 2025*

# book a session with me

1. [calendly](https://calendly.com/jaycodingtutor/30min)

# hire and get to know me

find ways to hire me, follow me and stay in touch with me.

1. [github](https://github.com/Jay-study-nildana)
1. [personal site](https://thechalakas.com)
1. [upwork](https://www.upwork.com/fl/vijayasimhabr)
1. [fiverr](https://www.fiverr.com/jay_codeguy)
1. [codementor](https://www.codementor.io/@vijayasimhabr)
1. [stackoverflow](https://stackoverflow.com/users/5338888/jay)
1. [Jay's Coding Channel on YouTube](https://www.youtube.com/channel/UCJJVulg4J7POMdX0veuacXw/)
1. [medium blog](https://medium.com/@vijayasimhabr)
