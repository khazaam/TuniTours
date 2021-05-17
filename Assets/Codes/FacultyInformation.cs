using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FacultyInformation : MonoBehaviour
{
    static string[] informationTechnology = {
            "3D Media Group",
            "5G, 6G, and other wireless networks",
            "Artificial Intelligence Research Group",
            "Audio and Speech Processing Research Group",
            "Centre of Excellence in Game Culture Studies",
            "Changing literacy in French: genres and forms",
            "CIVIT - Immersive Visual Technologies",
            "Computational Imaging Group",
            "Computer Engineering",
            "Computer Vision Group",
            "Computer-based Studies of Specialised Texts and Terminology (COSSTT)",
            "Discourse and Interaction",
            "Electric power systems and Smart Grids",
            "Electronics and energy",
            "Embedded systems",
            "Evolving Englished: multiple global English data in time and space (EvolvE)",
            "Financial Computing and Data Analytics",
            "Finnish Language and Social Participation",
            "Grid-Connected Power Electronics",
            "HelSINki",
            "High Voltage Engineering",
            "Human-Centered Technology (IHTE)",
            "Imaging and Computer Vision Research Group",
            "Informaation ja median tutkimuskeskus TRIM",
            "Learning for Intelligent Autonomous Robots",
            "Mathematical Systems Theory Research Group",
            "Modelling and Superconductivity",
            "Multimodal interaction research group MMIG",
            "Multimodality in Translation and Interpreting (MULTI)",
            "Multisensor Data Fusion",
            "Nano- and bio-communications",
            "Network and Information Security Group (NISEC)",
            "Performance",
            "Pervasive interaction research group PIRG",
            "Positioning and radio-based sensing/radar",
            "Predictive Society and Data Analytics Lab",
            "Printed and hybrid electronics",
            "Radio transceivers, RF signal processing and RF microelectronics",
            "RecSys: Group on Recommender Systems",
            "Research group for emotions, sociality and computing ESC",
            "Research group on Modelling and Superconductivity",
            "RIME - Research Group on Information and Media Practices",
            "Signal processing for wireless positioning group (TLTPOS)",
            "Signal Processing Research Center",
            "Software Engineering and Intelligent Systems (SEIntS)/Pori",
            "Spatial Studies and Environmental Humanities",
            "Statistical Machine Learning and Exploratory Data Analytics (SMiLE)",
            "System on Chip research group",
            "Tampere Logic Group",
            "Tampere Natural Language Processing Group (NLP)",
            "Tampere software engineering TASE",
            "Tampere Unit for Computer-Human Interaction TAUCHI",
            "Tampere Wireless Research Center",
            "Technology-supported Mathematics Education Research Group (TsMERG)",
            "The Changing Translatorial Landscape",
            "Thin-film electronics",
            "UAV communications",
            "Ultra Video Group",
            "Variation and Change in Finnish",
            "Visual interaction research group VIRG",
            "Wireless for vertical industries"
    };

    static string[] managementBusiness = {
            "Center for Research on Project and Service Business (CROPS)",
            "CITER - Center for Innovation and Technology Research",
            "Cost Management Center (CMC)",
            "Customer-Oriented Marketing Research Group",
            "Financial Management and Accounting Research Group",
            "Higher Education Group",
            "NOVI – Research Group for Information and Knowledge Management",
            "Operations and Supply Chain Group (OSCG)",
            "Research Centre on Transnationalism and Transformation (TRANSIT)",
            "Research Group of Business Law and Tax Law",
            "Research group of local and regional governance",
            "Research Group on Public Financial Management",
            "Research Group on Sustainability and Critical Accounting",
            "Research group Politics of Nature and the Environment (PONTE)",
            "RESPMAN Research Group",
            "Space and Political Agency Research Group (SPARG)",
            "Urban and Regional Studies Group (Sente)",
            "Wastebusters - research group focusing on food waste and circular economy",
            "Wellbeing at Work Research Group"
    };

    static string[] education = {
            "ECEPP: Early Childhood Education Institutions, Policies and Practices",
            "EduKnow: Knowledge, Power, and Politics in Education",
            "EduLit Educating for Future Literacies",
            "EQUJUST",
            "Higher Education in Transition (HET) research group",
            "Let's work together",
            "Multiculturalism, transnationalism and transformation in education (MTT)",
            "POISED Political Philosophies and Sociologies of Education",
            "Professional Growth and Learning",
            "REAL - Research Group for Education, Assessment and Learning",
            "Research Centre on Transnationalism and Transformation (TRANSIT)",
            "Research Engagement for Sustainable and Equitable Transformations (RESET)",
            "SMD - Subject‐matter didactics",
            "Spatial Socialization and Environmental Citizenship Research Collective SPECS"
    };

    static string[] medical = {
            "Adult stem cell",
            "Anatomy",
            "Bioimage informatics",
            "Bioinspired Materials and Robotics group",
            "Biophysics of the Eye",
            "Cancer Signaling",
            "Celiac disease in the adulthood",
            "Celiac Disease Research Center",
            "Cellular Biophysics",
            "Centre of Excellence in Body-on-Chip Research",
            "Clinical chemistry",
            "Clinical Physiology",
            "Computational biology",
            "Computational Biophysics and Imaging Group (CBIG)",
            "Computational neuroscience",
            "Cytokine biology",
            "Decision Support for Health",
            "Dentistry",
            "Department of Oncology and Radiotherapy",
            "Environmental Health",
            "Experimental Immunology",
            "Eye group",
            "Finnish Cardiovascular Research Center Tampere - FCRCT",
            "Finnish Cen¬ter of Excellence in Tumor Genetics Research",
            "General practice (Yleislääketiede)",
            "Geriatrics",
            "Global Health Group",
            "Heart Group",
            "Hematology and oncology",
            "Immunobiology of celiac disease",
            "Immunopharmacology",
            "Infant Cognition",
            "Infection and Cancer",
            "Infection Biology",
            "Intestinal Signalling and Epigenetics",
            "Laboratory of Bioengineering and Nanomedicine",
            "Laboratory of Biosystem Dynamics",
            "Laboratory of Regenerative Medicine",
            "Medical Biochemistry",
            "Micro- and Nanosystems Research Group",
            "Microbiology and Immunology",
            "Military medicine",
            "Mitochondrial Biology",
            "Molecular Biology of Prostate Cancer",
            "Molecular Immunology",
            "Nanoscale Phenomena and Measurements (NPM) research group",
            "Neuro Group",
            "Occupational health",
            "Ophthalmology",
            "Orthopaedics",
            "PELICAN (Personalized Cancer Medicine)",
            "Physiological Measurement Systems And Methods",
            "Predictive systems toxicology and pharmacology",
            "Prostate Cancer Research Center",
            "Protein Dynamics",
            "Psychiatric research group",
            "Quantitative Analysis of Medical Images",
            "Science Mimicking Life Research Center",
            "Sensor Technology and Biomeasurements",
            "Surgery (especially Vascular Surgery)",
            "Tampere Pancreas Group",
            "Vaccine development and immunology",
            "Vaccine Research Center",
            "Virology",
            "Wireless Identification and Sensing Systems Research Group (WISE Group)"
    };

    static string[] environment = {
            "Architectural Design and Sustainable Housing",
            "Architecture; Management of Built Heritage",
            "ASUTUT - Sustainable Housing Design",
            "Building Physics",
            "CADWES - Capacity Development in Water and Environmental Services",
            "Concrete and Bridge Structures",
            "Construction Management and Economics",
            "Metal and Lightweight Structures",
            "Renovation and service life engineering of structures",
            "Research Centre Terra",
            "SPREAD – Spatial & Speculative Research in Architectural Design",
            "Structural mechanics",
            "TerraRail",
            "Transport Research Centre Verne"
    };

    static string[] engineering = {
            "Aerosol Physics",
            "Applied Optics",
            "Ceramic Materials",
            "Cognitive Robotics group",
            "Digital hydraulics research group",
            "Energy and Biorefining",
            "FAST-Lab",
            "Hybrid Solar Cells (HSC)",
            "Icing Research",
            "IHA - Innovative Hydraulics and Automation",
            "Intelligent Networked Systems (IINES)",
            "Materials Characterization",
            "Mechanical Behavior of Materials",
            "Metals technology",
            "Metaplasmonics",
            "Microbial Electrochemical Technologies",
            "MRG - Mechatronics Research Group",
            "Optoelectronics Research Centre (ORC)",
            "Paper Converting and Packaging",
            "Photonic Compounds and Nanomaterials",
            "Photonic Glasses Group",
            "Plastics and Elastomer Technology",
            "Precision Nanomaterials Group",
            "Process Automation",
            "Production Systems and Technologies",
            "Radical Aerosol Physical Chemistry",
            "Smart Photonic Materials (SPM)",
            "Supramolecular chemistry of bio- and nanomaterials",
            "Surface engineering",
            "Surface Science",
            "Synthetic Biology",
            "Synthetic Chemistry",
            "Tampere Wear Center",
            "Tribology and machine elements",
            "Ultrafast Fiber Optics",
            "Wastewater and Waste Engineering for Circular Economy",
            "Water Engineering",
            "Zonal Hydraulics"
    };

    static string[] socialScience = {
            "Centre for Sociology of Democracy",
            "Cleaning up the North: Cleanliness, Work and Gender in the Nordic Countries, 1850–1940",
            "Contested Consent (CoCo): Social and Digital Borders and Orders of Intimacy in Young People’s Romantic Engagements (2019-2023)",
            "Encounters",
            "Gerontology Research Center GEREC",
            "HEX Centre of Excellence in the History of Experiences",
            "Human Information Processing Laboratory (HIP)",
            "HYPO Hyvinvoinnintutkimus Porissa (Research on Wellbeing in Pori) -research group",
            "Infectious Disease Epidemiology and Vaccine Programs in Public Health Practice",
            "Innovation Studies Group",
            "Lifestyle Migration Hub",
            "Managing new intensified job demands through self-regulative resources: a large-scale study across occupations and age groups",
            "Mobile professionals and families",
            "Narrare: Centre for Interdisciplinary Narrative Studies",
            "NEDIS - Research on Children's and Adolescents' Health Promotion",
            "Occupational Health Research Group",
            "Research Centre on Transnationalism and Transformation (TRANSIT)",
            "Science studies group",
            "Speech and Voice Research Laboratory",
            "Tampere research group for Cultural and Political Sociology (TCuPS)",
            "The Dynamics of Cultural Stratification: Tampere Group for Sociology of Culture",
            "Trauma and Children - Effective Ways of Help",
            "Trivium - Tampere Centre for Classical, Medieval, and Early Modern Studies",
            "WHO Collaborating Centre on Health in All Policies and the social determinants of health"
    };

    public Transform scrollUI;
    public RectTransform scrollArea;
    public Text facultyName;
    public Text scrollText;

    // Start is called before the first frame update
    void Start()
    {
        scrollUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, GetComponent<Camera>().transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject.transform.tag == "InformationTechnology")
            {
                scrollUI.gameObject.SetActive(true);
                facultyName.text = "Information Technology and Communication Sciences";
                AddResearchGroupNames(informationTechnology);

            }
            else if (hit.collider.gameObject.transform.tag == "Managment")
            {
                scrollUI.gameObject.SetActive(true);
                facultyName.text = "Management and Business";
                AddResearchGroupNames(managementBusiness);
            }
            else if (hit.collider.gameObject.transform.tag == "Education")
            {
                scrollUI.gameObject.SetActive(true);
                facultyName.text = "Education and Culture";
                AddResearchGroupNames(education);
            }
            else if (hit.collider.gameObject.transform.tag == "Medicine")
            {
                scrollUI.gameObject.SetActive(true);
                facultyName.text = "Medicine and Health Technology";
                AddResearchGroupNames(medical);
            }
            else if (hit.collider.gameObject.transform.tag == "Environment")
            {
                scrollUI.gameObject.SetActive(true);
                facultyName.text = "Built Environment";
                AddResearchGroupNames(environment);
            }
            else if (hit.collider.gameObject.transform.tag == "Engineering")
            {
                scrollUI.gameObject.SetActive(true);
                facultyName.text = "Engineering and Natural Sciences";
                AddResearchGroupNames(engineering);
            }
            else if (hit.collider.gameObject.transform.tag == "SocialScience")
            {
                scrollUI.gameObject.SetActive(true);
                facultyName.text = "Social Science";
                AddResearchGroupNames(socialScience);
            }
            else
            {
                scrollUI.gameObject.SetActive(false);
            }

        }
    }

    void AddResearchGroupNames(string[] researchGroupNames)
    {
        scrollText.text = "";
        scrollArea.sizeDelta = new Vector2(615, researchGroupNames.Length * 100f);
        for (int i = 0; i < researchGroupNames.Length; i++)
        {
            scrollText.text += researchGroupNames[i] + "\n" + "\n";
        }
    }
}
