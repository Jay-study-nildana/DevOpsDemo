You’re absolutely correct—**giving students service principal access to your resource group can be risky**, because:

- They could accidentally (or intentionally) create, modify, or delete resources in that group.
- This might include expensive resources (e.g., large VMs, premium databases) that can incur significant costs.

## **Safer Alternative: Publish Profile**

- **Publish Profile** is a deployment credential specific to a web app.
- It allows students to **deploy code to the web app only** (via Visual Studio, Azure CLI, GitHub Actions, etc.).
- They **cannot create/delete or modify other Azure resources**.
- No access to the Azure Portal (except for deployment), so they can’t accidentally rack up costs.

### **Best Practice for Teaching**
- **Share only the publish profile** for the web app with your students.
- **Keep service principal access restricted** to yourself or trusted automation.

---

**Summary:**
> Use publish profiles for student deployments.  
> Avoid granting broad service principal or resource group access unless strictly necessary.

Let me know if you want steps or a sample workflow for sharing publish profiles safely!

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