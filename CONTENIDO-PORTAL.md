# Core OnBoarding — Contenido del Portal

> Todo lo que hay que saber de Core y no te han contado

---

## Inicio

### Secciones del portal

| Sección | Descripción |
|---------|-------------|
| **Visión General** | Qué es, para quién, propuesta de valor y conceptos clave del producto. |
| **Arquitectura Funcional** | Módulos, flujos entre áreas, navegación, roles y perfiles de usuario. |
| **Conceptos Técnicos** | SaaS, arquitectura, seguridad, integraciones y rendimiento explicados para todos. |
| **Guía Funcional** | Detalle por módulo: funcionalidades, flujos, pantallas, KPIs y roadmap. |
| **Argumentario Comercial** | Elevator pitch, argumentos, objeciones, competidores y casos de éxito. |
| **Implantación** | Metodología, configuración inicial y migración de datos. |
| **Stack Tecnológico** | Tecnologías, herramientas y decisiones técnicas de la plataforma. |
| **Observabilidad y Soporte** | Trazabilidad, Grafana, monitorización por tenant y usuario, y diagnóstico. |
| **Proveedor Cloud** | Google Cloud Platform: infraestructura, Kubernetes, redundancia, backups y seguridad. |
| **Inteligencia Artificial** | Agentes IA con lenguaje natural: cambios masivos, widgets, reports, filtros y MCP. |
| **Bancos de Datos** | Integración con eDam/Electronet y GO!Catalog: tarifas actualizadas diariamente. |
| **Despliegue y Versiones** | Entornos compartidos, flujo de Beta a Stable, hotfixes y actualizaciones continuas. |
| **FinOps** | Gestión financiera del cloud: visibilidad, optimización y coste justo para el cliente. |
| **BackOffice Core** | Panel de control interno: instancias, tenants, usuarios y actualizaciones. |

> **Este portal está en construcción.** Cada sección contiene la estructura de contenido prevista. El equipo de R&D irá completando el contenido progresivamente.

---

# 1. Visión General

## 1.1 Qué es la plataforma

Telematel inicia una nueva etapa tecnológica con el desarrollo de **CORE**, la nueva generación de ERP empresarial diseñada para responder a los retos actuales y futuros del sector de la distribución técnica y las empresas instaladoras.

CORE nace como una evolución estratégica respecto a los ERPs actuales de Telematel —**GO!Manage** y **SoftSumind**—, incorporando una arquitectura moderna, SaaS y API First, preparada para la integración, la automatización y el aprovechamiento de la Inteligencia Artificial.

La plataforma está concebida para ofrecer una solución escalable, flexible y preparada para el crecimiento de las empresas del sector eléctrico, fontanería, climatización y materiales técnicos afines, cubriendo tanto las necesidades actuales como los nuevos modelos operativos digitales que marcarán el futuro del mercado.

### ¿Qué es CORE?

CORE es la nueva plataforma ERP cloud de Telematel, desarrollada bajo una arquitectura moderna orientada a servicios, totalmente web y preparada para operar como solución **SaaS** (Software as a Service).

La plataforma ha sido diseñada bajo varios principios fundamentales:

- Arquitectura API First
- Separación completa FrontEnd / BackEnd
- Entorno Cloud SaaS
- Preparada para IA e integración
- Escalabilidad funcional y tecnológica
- Experiencia de usuario moderna y accesible desde cualquier dispositivo

CORE no es únicamente una migración tecnológica del ERP actual, sino una **nueva plataforma estratégica preparada para el futuro del sector**. Su objetivo es unificar y evolucionar las capacidades funcionales existentes en **GO!Manage** y **SoftSumind**, y transformarlas en una plataforma única, moderna y preparada para los próximos años.

### Diferencias respecto al ERP actual

| Aspecto | GO!Manage / SoftSumind | CORE |
|---------|------------------------|------|
| **Arquitectura** | Cliente-Servidor | SaaS Web |
| **Tecnología** | Progress tradicional | Arquitectura moderna API First |
| **FrontEnd** | Acoplado al BackEnd | Separado completamente |
| **Acceso** | Cliente instalado | Navegador Web |
| **Infraestructura** | Servidores locales | Cloud |
| **Escalabilidad** | Limitada | Alta escalabilidad |
| **Integraciones** | Más complejas | APIs abiertas |
| **Actualizaciones** | Manuales | Centralizadas |
| **IA** | Limitada | Preparada para IA |
| **Movilidad** | Parcial | Total |
| **Despliegue** | Complejo | Simplificado |
| **Costes IT cliente** | Elevados | Reducidos |
| **Innovación** | Más lenta | Continua |

## 1.2 Público objetivo

### Fases de liberación

#### CORE 1

Primera liberación orientada principalmente a cubrir las funcionalidades de GO!Manage.

- **Origen:** Nuevo cliente / Actual cliente del ERP GO!Manage
- **Tipo de empresas:** Distribuidores pequeños, medianos y empresas multi-sede
- **Sectores:** Electricidad, Fontanería, Climatización, Material técnico especializado
- **Características objetivo:** Empresas con necesidad de modernización, que buscan reducir infraestructura, que necesitan movilidad y acceso web

#### CORE 2

Ampliación funcional para cubrir GO!Manage y SoftSumind, incluyendo funcionalidades avanzadas para grandes distribuidores.

- **Origen:** Nuevo cliente / Actual cliente de GO!Manage y SoftSumind
- **Tipo de empresas:** Distribuidores medianos, grandes distribuidores, grupos empresariales
- **Características objetivo:** Alta escalabilidad, grandes volúmenes de información, operativas complejas, integraciones avanzadas, automatización logística y financiera

#### CORE 3

Ampliación para cobertura completa para empresas instaladoras.

- **Origen:** Nuevo cliente / Actual cliente del ERP GO!Manage
- **Tipo de empresas:** Instaladores pequeños, medianos, empresas de servicios técnicos
- **Sectores:** Instalaciones eléctricas, Climatización, Fontanería, Mantenimiento técnico
- **Características objetivo:** Movilidad, gestión operativa en campo, acceso remoto, digitalización documental, integración comercial y técnica

### Casos de uso ideales

- **Empresa distribuidora digitalizada:** Automatizar procesos, integrar eCommerce, mejorar trazabilidad, información en tiempo real
- **Empresas multisede:** Gestión centralizada, operación distribuida, acceso global, escalabilidad organizativa
- **Empresas orientadas a integración:** Conectar con plataformas externas, clientes, proveedores, operadores logísticos, sistemas de BI
- **Empresas orientadas a IA:** Automatización documental, procesamiento inteligente, asistentes IA, búsqueda avanzada, predicción
- **Empresas en crecimiento:** Escalar rápidamente, reducir inversiones iniciales, incorporar nuevas sedes y usuarios fácilmente
- **ERP preparado para el ecosistema futuro:** Automatización avanzada, IA generativa, APIs abiertas, integración continua, cloud computing, datos en tiempo real

## 1.3 Propuesta de valor

### Objetivos para Telematel

- **Evolución tecnológica:** Plataforma moderna, mantenible y escalable, alineada con las tendencias del mercado del software empresarial
- **Consolidación funcional:** Unificar funcionalidades de distintos ERPs, reducir duplicidades, centralizar evolución y mantenimiento, acelerar desarrollos futuros
- **Modelo SaaS recurrente:** Incrementar ingresos recurrentes, monetizar servicios cloud, mejorar la estabilidad financiera, reducir dependencia de proyectos de infraestructura
- **Preparación para IA y automatización:** Automatización inteligente, integración con IA generativa, procesamiento documental, asistentes inteligentes, integraciones externas avanzadas
- **Escalabilidad empresarial:** Soportar clientes de mayor tamaño, escalar recursos dinámicamente, mejorar rendimiento y disponibilidad, facilitar despliegues continuos

### Objetivos para los clientes

- **Eliminación de infraestructura local:** Eliminar servidores locales, reducir costes de hardware y mantenimiento IT, evitar actualizaciones complejas
- **Acceso universal:** Desde cualquier ubicación, navegador web, entornos híbridos y remotos, mayor movilidad empresarial
- **Integración sencilla:** eCommerce, plataformas B2B, marketplaces, software de logística, SGA, BI y analítica, CRM, plataformas documentales, IA y automatización
- **Evolución continua:** Mejoras continuas, actualizaciones automáticas, nuevas funcionalidades más rápidas, innovación constante
- **Experiencia de usuario moderna:** Mayor productividad, mejor usabilidad, procesos más intuitivos, reducción de tiempos operativos

### Problemas que resuelve CORE

- **Limitaciones tecnológicas del modelo actual:** Dependencia de infraestructura local, complejidad de despliegue, dificultad de integración, escalabilidad limitada, mayor coste operativo → CORE elimina estas barreras mediante una arquitectura cloud moderna
- **Dificultad de integración:** Integraciones complejas, dependencias técnicas propietarias, intercambio manual de información, sistemas aislados → Resuelto gracias a su enfoque API First
- **Necesidad de movilidad y acceso remoto:** Delegaciones, movilidad, teletrabajo, dispositivos múltiples → CORE ofrece acceso web universal
- **Necesidad de automatización e IA:** Automatizar tareas repetitivas, procesar documentos automáticamente, obtener ayuda inteligente, analizar información en tiempo real → CORE está diseñada específicamente para facilitar estas capacidades
- **Crecimiento y escalabilidad empresarial:** Más usuarios, más sedes, más volumen de datos, más automatización → CORE permitirá escalar sin las limitaciones tradicionales

## 1.4 Conceptos clave

### Visión SaaS y estrategia futura

#### Plataforma cloud empresarial

CORE representa la transformación de Telematel hacia un modelo cloud empresarial moderno: plataforma 100% SaaS, servicios centralizados, actualizaciones continuas, alta disponibilidad y seguridad gestionada centralmente.

#### ERP conectado

CORE estará preparado para integrarse con ecosistemas digitales sectoriales, plataformas de fabricantes, distribución online, marketplaces, herramientas colaborativas y plataformas logísticas.

#### ERP preparado para IA

Uno de los pilares estratégicos de CORE es convertirse en una plataforma preparada para la Inteligencia Artificial: automatización documental, interpretación de facturas y pedidos, asistentes inteligentes, generación automática de procesos, ayuda contextual al usuario, búsqueda inteligente y análisis predictivo.

#### Evolución continua

CORE está concebido como una plataforma viva y evolutiva: liberaciones continuas, nuevos módulos cloud, automatización creciente, mayor interoperabilidad y arquitectura extensible.

### Conclusión

CORE representa la **transformación estratégica de Telematel** hacia una nueva generación de soluciones ERP cloud, conectadas, escalables y preparadas para el futuro. La nueva plataforma permitirá evolucionar desde los modelos tradicionales cliente-servidor hacia un ecosistema SaaS moderno, preparado para la integración, la automatización y la Inteligencia Artificial.

Con CORE, Telematel no solo moderniza su tecnología, sino que **construye la base sobre la que evolucionarán los procesos empresariales de sus clientes** durante los próximos años.

---

# 2. Arquitectura Funcional

## 2.1 Multitenancy

Core OnBoarding utiliza una arquitectura **multitenant** donde múltiples clientes (tenants) comparten la misma infraestructura y aplicación, con aislamiento completo de datos. Cada tenant corresponde a un cliente (grupo empresarial) distinto.

### Modelos de tenancy

Existen diferentes enfoques de multitenancy, desde el aislamiento total hasta compartición total. Core OnBoarding se posiciona en **Application Tenancy**: aplicación compartida con base de datos segregada.

| Modelo | Descripción |
|--------|-------------|
| **Isolated Tenancy** | Todo separado (aplicación, tenant, base de datos, infraestructura) |
| **Infrastructure Tenancy** | Infraestructura compartida, el resto separado |
| **Application Tenancy ★** | Aplicación e infraestructura compartidas, base de datos segregada — **← Core OnBoarding** |
| **Shared Tenancy** | Todo compartido |

### Jerarquía: Tenant / Empresa / Sede

**Tenant**

1. Un Tenant corresponde a un **cliente** (grupo empresarial).
2. Un Tenant es **estanco**. No se puede acceder de un tenant a otro.
3. Un usuario puede tener acceso a 1 o varios Tenants.

**Empresa**

1. Las Empresas son independientes entre ellas. Tienen **distinto CIF**.
2. Los artículos, clientes, proveedores y tarifas **podrán compartirse** entre las empresas del Tenant.
3. Países, provincias y divisas serán **comunes** en las empresas del Tenant.

**Sede**

1. Los stocks van por sede (**único Almacén**).
2. No se comparte almacén entre Sedes ni empresas.
3. Cada Sede tendrá sus **movimientos de almacén** propios.

### Principio clave de diseño

La Aplicación, **a nivel de usuario, no es multiempresa**. Cada pantalla corresponderá a una empresa/sede determinada para realizar las transacciones de Ofertas, Pedidos, Albaranes, Facturas, etc.

Los procesos de **consolidaciones entre empresas y entre Tenants** serán bajo software y seguridad específico para ello.

### Aislamiento de datos

**Estanco entre Tenants:**

| Recurso | Aislamiento |
|---------|-------------|
| Base de datos | Separada por tenant (schema o instancia) |
| Usuarios | Cada tenant tiene los suyos |
| Ficheros / documentos | Bucket separado por tenant |
| Configuración funcional | Independiente por tenant |
| Logs / auditoría | Segregados y filtrados |
| Backups | Restaurables por tenant |

**Compartido dentro del Tenant:**

| Recurso | Nivel de compartición |
|---------|----------------------|
| Artículos / catálogo | Compartible entre empresas del tenant |
| Clientes / proveedores | Compartible entre empresas del tenant |
| Tarifas base | Compartible, con personalización por empresa |
| Países, provincias, divisas | Comunes a todo el tenant |
| Stock | **No compartido** — siempre por sede |
| Transacciones (pedidos, facturas...) | **No compartido** — por empresa/sede |

### Ventajas del modelo Application Tenancy

- **Seguridad** — Datos 100% aislados entre clientes. Imposible acceso cruzado.
- **Eficiencia** — Aplicación e infraestructura compartidas reducen costes.
- **Actualizaciones** — Un despliegue actualiza a todos los tenants simultáneamente.
- **Backups** — Restauración granular por tenant sin afectar al resto.

---

## 2.2 Estructura de módulos

*(Contenido pendiente de desarrollo)*

## 2.3 Relación entre módulos

*(Contenido pendiente de desarrollo)*

## 2.4 Navegación general

*(Contenido pendiente de desarrollo)*

## 2.5 Roles y perfiles

*(Contenido pendiente de desarrollo)*

---

## 2.6 Multi Empresa / Sede

Core OnBoarding soporta de forma nativa la gestión **multi-empresa y multi-sede**, permitiendo que una misma instalación sirva a varias sociedades, delegaciones o centros de trabajo con datos aislados y configuraciones independientes.

### Modelo de datos

| Concepto | Descripción |
|----------|-------------|
| **Tenant** | Entidad raíz — representa al cliente (grupo empresarial) |
| **Empresa** | Sociedad jurídica dentro del tenant (CIF propio, contabilidad separada) |
| **Sede / Delegación** | Centro de trabajo físico dentro de una empresa |
| **Almacén** | Ubicación logística vinculada a una sede |

**Jerarquía de ejemplo:**

```
Tenant (Grupo ABC)
├─ Empresa 1 (ABC Madrid S.L.)
│  ├─ Sede Central
│  └─ Delegación Sur
├─ Empresa 2 (ABC Barcelona S.A.)
│  └─ Sede Única
└─ Empresa 3 (ABC Portugal Lda.)
   └─ Filial Lisboa
```

### Capacidades principales

**Configuración por empresa:**
- Datos fiscales y razón social propios
- Secuencias de documentos independientes
- Plan contable y ejercicios separados
- Condiciones comerciales por sociedad

**Configuración por sede:**
- Dirección y datos de contacto propios
- Almacenes y stock segregado
- Tarifas y descuentos locales
- Horarios y calendarios laborales

**Operaciones inter-empresa:**
- Transferencias de stock entre sedes
- Facturación inter-company automática
- Consolidación contable a nivel grupo
- Reporting consolidado o por entidad

### Control de acceso por entidad

**Usuarios y permisos:**

Cada usuario se asocia a una o varias empresas/sedes con permisos granulares:

- **Acceso global** — Ve todas las empresas del tenant (director general)
- **Acceso multi-empresa** — Accede a un subconjunto de sociedades
- **Acceso por sede** — Solo ve datos de su delegación
- Cambio de contexto empresa/sede sin cerrar sesión

**Filtrado automático:**

El sistema aplica filtros de forma transparente:

- Todas las consultas se filtran por empresa/sede activa
- Los documentos se generan con la identidad de la empresa seleccionada
- Los listados solo muestran registros de las entidades autorizadas
- Los informes se acotan al contexto del usuario

---

## 2.7 Seguridad Funcional

El modelo de seguridad de Core OnBoarding garantiza que cada usuario accede **únicamente a los datos y acciones** que le corresponden según su rol, empresa y sede, aplicando el principio de mínimo privilegio en todas las capas.

### Modelo de permisos

| Capa | Qué controla | Ejemplo |
|------|--------------|---------|
| **Rol** | Conjunto de permisos funcionales | Administrador, Comercial, Almacenero |
| **Permiso** | Acción concreta sobre un recurso | Pedidos.Crear, Clientes.Editar |
| **Ámbito** | Alcance de datos visibles | Todas las sedes, Solo mi sede |
| **Restricción** | Limitación adicional por campo | Solo pedidos < 10.000 € |

**Principios:**

- **Mínimo privilegio** — Solo lo necesario
- **Deny by default** — Sin permiso explícito = denegado
- **Segregación de funciones** — Crear ≠ Aprobar
- **Auditable** — Toda acción queda registrada
- **Configurable** — Sin tocar código

### Autenticación

**Métodos soportados:**
- Usuario + contraseña (con política de complejidad)
- SSO con Azure AD / Google Workspace
- SAML 2.0 / OpenID Connect
- MFA (TOTP, SMS, email)

**Sesiones:**
- Tokens JWT con expiración configurable
- Refresh tokens con rotación
- Cierre de sesión remoto
- Sesiones concurrentes limitadas

**Políticas de contraseña:**
- Longitud mínima configurable (≥ 8)
- Complejidad: mayúsculas, números, símbolos
- Historial: no repetir últimas N contraseñas
- Expiración y renovación periódica

### Autorización funcional

**Permisos por módulo:**

Cada módulo define sus permisos CRUD + acciones especiales:

| Módulo | Permisos |
|--------|----------|
| Pedidos | Ver, Crear, Editar, Eliminar, Aprobar, Expedir |
| Clientes | Ver, Crear, Editar, Eliminar, Bloquear |
| Stock | Ver, Ajustar, Transferir, Inventariar |
| Facturación | Ver, Emitir, Anular, Contabilizar |
| Configuración | Ver, Modificar (solo Administradores) |

**Auditoría:**

Registro completo de actividad para cumplimiento y trazabilidad:

- Quién hizo qué, cuándo y desde dónde (IP, dispositivo)
- Cambios en datos sensibles (antes/después)
- Intentos de acceso fallidos
- Cambios de permisos y roles
- Exportación a sistemas SIEM externos
- Retención configurable (mínimo 1 año)

### Protección de datos

- **Cifrado** — TLS 1.3 en tránsito, AES-256 en reposo. Datos sensibles con cifrado adicional a nivel de campo.
- **Enmascaramiento** — Datos personales enmascarados según perfil. CIFs, cuentas bancarias y emails protegidos por defecto.
- **GDPR / LOPD** — Derecho al olvido, portabilidad, consentimientos y registro de tratamientos integrados.

---

# 3. Conceptos Técnicos

## 3.1 Qué significa SaaS

*(Contenido pendiente de desarrollo)*

## 3.2 Arquitectura de alto nivel

*(Contenido pendiente de desarrollo)*

## 3.3 Seguridad

*(Contenido pendiente de desarrollo)*

## 3.4 Integraciones

*(Contenido pendiente de desarrollo)*

## 3.5 Rendimiento y escalabilidad

*(Contenido pendiente de desarrollo)*

---

# 4. Guía Funcional por Área

## 4.0 Alcance funcional general

Visión completa de los circuitos funcionales, integraciones y roadmap de versiones de Core OnBoarding.

### Roadmap de versiones

**CORE 1** → Mar-27 (6 meses de adelanto)

Consolida CORE 0 (Dic-26) y CORE 1 (Sep-27) en una entrega adelantada.

- Multiempresa - Multisede
- Multiubicación
- eDam - GO!Catalog
- SII - Verifactu - Batuz
- Integración CLC, PTL
- Integración CRM/ecommerce vía API
- Circuitos Almacén, Compras, Ventas, Logística y Finanzas

**CORE 2** → Mar-28 (18 meses de adelanto)

Consolida CORE 2 (Sep-28), CORE 3 (Mar-29) y CORE 4 (Sep-29) en una sola.

- Integración SGA / IntraDAM / GSGESTIÓN
- Mobilidad de Almacén
- Completar requerimientos DAM y SS de los circuitos
- Almacén, Compras, Ventas, Logística y Finanzas completos
- Gestión de Taller

**Línea cronológica — Plan original vs. Plan acelerado:**

- ~~C0 — Dic-26 (original)~~
- **C1 — Mar-27 (entrega real) ✓**
- ~~C1 — Sep-27 (original)~~
- **C2 — Mar-28 (entrega real) ✓**
- ~~C2 — Sep-28 (original)~~
- ~~C3 — Mar-29 (original)~~
- ~~C4 — Sep-29 (original)~~

CORE 1 → 6 meses de adelanto | CORE 2 → 18 meses de adelanto

### Circuitos funcionales

**Ventas:**
- Ofertas y presupuestos
- Pedidos de venta
- Albaranes de venta
- Facturación (incluye SII, Verifactu, Batuz)
- Gestión de tarifas multi-nivel
- Rappels y descuentos por volumen
- Condiciones comerciales por cliente
- Devoluciones y abonos

**Compras:**
- Propuestas de compra automáticas
- Pedidos de compra
- Recepción de mercancía (albaranes entrada)
- Facturación de proveedor
- Gestión de tarifas de compra
- Rappels de proveedor
- Comparativa de precios entre proveedores
- Devoluciones a proveedor

**Almacén y Logística:**
- Gestión de stock por sede y almacén
- Multiubicación (zonas, estanterías, huecos)
- Picking y preparación de pedidos
- Expedición y seguimiento de envíos
- Transferencias entre almacenes
- Inventarios y ajustes de stock
- Movilidad de almacén (CORE 2)
- Integración con SGA (CORE 2)

**Finanzas:**
- Contabilidad general y analítica
- Gestión de cobros y pagos
- Remesas bancarias
- Conciliación bancaria
- Tesorería y previsiones
- Impuestos (IVA, IRPF, SII)
- Cierres contables
- Consolidación multi-empresa

**Gestión de Taller (CORE 2):**
- Órdenes de trabajo
- Partes de trabajo y horas
- Consumo de materiales
- Presupuestos de reparación
- Facturación de servicios
- Historial por equipo / instalación

**Maestros y Configuración:**
- Artículos con atributos técnicos (ETIM)
- Clientes y proveedores
- Tarifas y condiciones comerciales
- Familias, subfamilias, marcas
- Almacenes, ubicaciones
- Empresas, sedes, usuarios
- Series de documentos
- Configuración fiscal

### Integraciones incluidas

**Bancos de datos:**
- eDam / Electronet
- GO!Catalog (Telematel)

**Facturación electrónica:**
- SII (Suministro Inmediato de Información)
- Verifactu
- Batuz (País Vasco)

**Sistemas externos:**
- CRM / eCommerce vía API REST
- CLC, PTL
- SGA / IntraDAM / GSGESTIÓN (CORE 2)

### Funcionalidades transversales

- Multiempresa
- Multisede
- Multiubicación
- Multitarifa
- IA integrada
- Movilidad

---

# 5. Argumentario Comercial

## 5.1 Elevator Pitch

Mensajes clave para presentar Core OnBoarding en 30 segundos, 2 minutos o 5 minutos según el contexto y el interlocutor.

### Pitch de 30 segundos

> "Core OnBoarding es el ERP cloud de nueva generación diseñado específicamente para la distribución de material eléctrico, fontanería, climatización y construcción. Elimina la dependencia de sistemas obsoletos, se adapta a cada empresa sin desarrollo a medida, y permite a tus equipos trabajar desde cualquier lugar con la misma potencia. Todo en un modelo SaaS sin inversión inicial."

### Pitch de 2 minutos

**El problema:**
- ERPs genéricos que no entienden la distribución profesional
- Sistemas on-premise costosos, lentos de actualizar y difíciles de mantener
- Personalizaciones que encarecen cada cambio y bloquean las actualizaciones
- Equipos comerciales sin movilidad real ni datos en tiempo real
- Integraciones manuales con proveedores, logística y contabilidad

**La solución:**
- ERP vertical: pensado desde cero para distribución profesional
- 100% cloud (Google Cloud) con SLA del 99.95%
- Configuración sin código: multi-empresa, multi-sede, multi-tarifa
- Movilidad completa: web responsive + app progresiva
- Inteligencia artificial integrada para automatizar lo repetitivo
- Modelo SaaS: pago mensual, sin inversión inicial, siempre actualizado

### Pitch de 5 minutos — por audiencia

**Director General / CEO:**
- Visibilidad total del negocio en tiempo real
- Reducción de costes IT del 40-60%
- Escalabilidad: crece contigo sin reinversión
- Independencia tecnológica: sin vendor lock-in
- Cumplimiento normativo garantizado (GDPR, ENS)

**Director Comercial:**
- CRM integrado con pedidos y facturación
- Tarifas, descuentos y rappels automáticos
- Acceso móvil a catálogo, stock y pedidos
- Reporting comercial en un clic
- IA para identificar oportunidades de venta

**Director IT / CTO:**
- Sin servidores que mantener (full managed)
- API REST completa para integraciones
- Kubernetes + GitOps: DevOps de verdad
- Seguridad enterprise: SSO, MFA, cifrado E2E
- Observabilidad total: Grafana, logs, traces

**Director Financiero / CFO:**
- Coste predecible: cuota mensual por usuario
- Sin CAPEX: no hay inversión en infraestructura
- ROI en menos de 12 meses
- Contabilidad integrada multi-empresa
- Facturación electrónica y SII incluidos

**Director de Logística:**
- Gestión de almacenes con ubicaciones
- Picking, packing y expedición digitalizados
- Control de stock en tiempo real multi-almacén
- Integración con transportistas
- Trazabilidad completa de lotes y series

**Usuarios finales:**
- Interfaz moderna e intuitiva
- IA que les ayuda con lenguaje natural
- Menos clics, más productividad
- Acceso desde cualquier dispositivo
- Formación mínima necesaria

### Mensaje diferenciador

> "No es un ERP genérico adaptado. Es un ERP *nacido* para la distribución profesional, con inteligencia artificial, en la nube, y sin inversión inicial."

---

## 5.2 Argumentos de Venta

Razones concretas y cuantificables para elegir Core OnBoarding frente a la competencia o frente a mantener el sistema actual.

### Argumentos principales

**1. Vertical para distribución**

No es un ERP genérico que necesitas adaptar durante meses. Core nace con:
- Tarifas multi-nivel con escalados por volumen
- Gestión de rappels y dto. comerciales complejos
- Catálogo con atributos técnicos del sector (calibre, potencia, sección...)
- Integración nativa con catálogos de fabricantes (ETIM, BMEcat)
- Gestión de corte (cables, tubería) y unidades de venta vs. stock

**2. Cloud nativo = cero infraestructura**

El cliente no necesita:
- Servidores propios ni CPD
- Técnicos de sistemas para mantener el ERP
- Gestionar backups, parches o actualizaciones
- Preocuparse por la seguridad perimetral
- Pagar licencias de SO, BD o middleware

**Ahorro estimado:** 40-60% vs. solución on-premise equivalente.

**3. IA integrada de serie**

Funcionalidades que la competencia no ofrece:
- Cambios masivos por lenguaje natural (sin SQL, sin exports)
- Generación de informes bajo demanda conversacional
- Dashboards personalizados pidiendo al asistente
- Filtrado inteligente en todas las vistas
- Automatización de tareas repetitivas sin programar

**4. Multi-todo de serie**

Sin módulos adicionales ni desarrollos extra:
- **Multi-empresa:** sociedades con contabilidad separada
- **Multi-sede:** delegaciones con stock independiente
- **Multi-almacén:** ubicaciones y zonas de picking
- **Multi-tarifa:** precios por cliente, grupo, zona, volumen
- **Multi-idioma:** interfaz localizable

**5. Siempre actualizado**

Modelo SaaS con entregas continuas:
- Actualizaciones automáticas sin paradas
- Nuevas funcionalidades cada sprint (2 semanas)
- Sin coste de migración entre versiones
- El cliente siempre tiene la última versión
- Feedback de clientes incorporado al roadmap

**6. Tiempo de implantación récord**

Gracias a la configurabilidad sin código:
- Setup básico operativo en 4-6 semanas
- Implantación completa en 2-4 meses (vs. 6-12 meses de la competencia)
- Migración de datos asistida con herramientas propias
- Formación reducida por interfaz intuitiva + IA
- Go-live progresivo por módulos si se prefiere

### ROI estimado

| Concepto | Ahorro estimado | Detalle |
|----------|-----------------|---------|
| Infraestructura IT | 40-60% | Eliminación de servidores, licencias, mantenimiento |
| Tiempo administrativo | 30-40% | Automatización de tareas repetitivas con IA |
| Errores de gestión | 50-70% | Validaciones automáticas, flujos guiados |
| Tiempo de formación | 60% | Interfaz intuitiva + asistente IA |
| Coste de implantación | 40-50% | Configuración vs. desarrollo a medida |

*Estimaciones basadas en comparativa con soluciones on-premise del sector. Los resultados reales varían según el cliente.*

---

## 5.3 Objeciones Típicas

Respuestas preparadas para las objeciones más frecuentes que surgen en el proceso comercial. Cada objeción incluye la respuesta recomendada y datos de soporte.

**"Ya tenemos un ERP y funciona"**

> "Entendemos que funciona. La pregunta es: ¿cuánto os cuesta que funcione? Mantener un sistema legacy implica costes ocultos: servidores, técnicos dedicados, personalizaciones que bloquean actualizaciones, y falta de movilidad. Core OnBoarding no es un cambio, es una evolución: se monta en paralelo, se migra progresivamente y desde el día uno reduce costes operativos."

**"La nube no es segura"**

> "Google Cloud tiene más certificaciones de seguridad que cualquier CPD propio (ISO 27001, SOC 2, ENS Alta, GDPR). Los datos están cifrados en reposo y en tránsito, con backups automáticos y disaster recovery en otra región. Es objetivamente más seguro que un servidor en la trastienda con un antivirus."

**"Es muy caro"**

> "Comparemos el TCO real: licencia + servidores + mantenimiento + técnicos + actualizaciones de vuestro sistema actual vs. una cuota mensual todo incluido. En el 90% de los casos, Core sale más económico al segundo año. Y además incluye funcionalidades (IA, movilidad, BI) que con otro sistema serían módulos adicionales de pago."

**"No quiero depender de Internet"**

> "¿Cuántas veces se ha caído vuestra conexión a Internet este año? Probablemente menos que vuestro servidor. Google Cloud tiene un SLA del 99.95%. Además, la app progresiva tiene caché offline para consultas básicas y el sistema de pedidos puede trabajar desconectado y sincronizar al recuperar conexión."

**"La migración es un riesgo"**

> "Tenemos un proceso de migración probado con herramientas de validación automática. Se hace en paralelo: el sistema antiguo sigue funcionando hasta que todo está verificado. No hay salto al vacío. Además, la migración incluye limpieza de datos y detección de inconsistencias — muchos clientes salen con datos más limpios que antes."

**"Mi equipo no se adaptará"**

> "La interfaz está diseñada para que cualquier persona que use un móvil pueda usarla sin formación intensiva. Además, el asistente IA ayuda en tiempo real: si el usuario no sabe hacer algo, lo describe en lenguaje natural y el sistema lo hace. Es literalmente más fácil que vuestro sistema actual."

**"¿Y si la empresa desaparece?"**

> "Los datos son siempre del cliente. Existe cláusula de escrow y derecho de exportación total en cualquier momento (formatos estándar: CSV, JSON, SQL). Además, al ser tecnología estándar (Kubernetes, PostgreSQL, .NET), cualquier equipo técnico podría operar el sistema en caso extremo."

**"Necesito personalizaciones muy específicas"**

> "Core está diseñado para ser configurable sin código: campos custom, flujos personalizados, reglas de negocio configurables, informes a medida con IA. El 95% de las necesidades se resuelven con configuración. Para el 5% restante, existe un sistema de extensiones que no bloquea las actualizaciones."

---

## 5.4 Comparativa con Competidores

Posicionamiento de Core OnBoarding frente a las soluciones más habituales en el sector de distribución de material eléctrico, fontanería y climatización.

### Comparativa general

| Característica | **Core OnBoarding** | SAP Business One | Microsoft Dynamics | ERPs sectoriales legacy |
|---------------|---------------------|------------------|-------------------|------------------------|
| Modelo de despliegue | **100% Cloud** | Híbrido | Híbrido | On-premise |
| Vertical para distribución | **Nativo** | Add-ons | Vertical partner | Sí |
| Inteligencia Artificial | **Integrada** | No | Copilot (limitado) | No |
| Multi-empresa nativo | **Sí** | Licencia extra | Sí | Parcial |
| Actualizaciones | **Continuas** | Anuales | Semestrales | Manuales |
| Tiempo de implantación | **2-4 meses** | 6-12 meses | 6-9 meses | 3-6 meses |
| Coste primer año (20 usuarios) | **€€** | €€€€ | €€€€ | €€€ |
| Movilidad real | **PWA nativa** | App básica | Mobile app | No / Limitada |
| API abierta | **REST completa** | Service Layer | OData | Limitada |

### Ventajas clave por competidor

**vs. SAP Business One:**
- Sin coste de licencia inicial (SAP ~€3.000/usuario)
- No necesita partner de implantación costoso
- Funcionalidad sectorial sin add-ons de terceros
- IA conversacional integrada (SAP no la tiene)
- Implantación 3x más rápida

**vs. Microsoft Dynamics 365:**
- Vertical real vs. plataforma genérica
- Precio predecible (Dynamics escala con módulos)
- No depende del ecosistema Microsoft completo
- IA más potente que Copilot para ERP
- Menor complejidad de configuración

**vs. ERPs legacy sectoriales:**
- Cloud real vs. "poner el servidor en un hosting"
- Interfaz moderna vs. pantallas de los 90
- IA y automatización vs. procesos manuales
- Actualizaciones continuas vs. versiones estancadas
- API abierta vs. integración por ficheros planos

### ¿Cuándo NO somos la mejor opción?

**Transparencia comercial** — Es importante saber cuándo Core no es el mejor fit:

- **Fabricantes puros** — Si el negocio principal es fabricación (no distribución), un MRP/MES especializado puede ser mejor.
- **Empresas > 500 usuarios** — Para grandes corporaciones con procesos muy complejos, SAP S/4HANA puede ser más adecuado.
- **Distribución farmacéutica o alimentaria** — Sectores con regulación muy específica (trazabilidad sanitaria) pueden necesitar verticales propios.

---

## 5.5 Casos de Éxito

Ejemplos representativos de implantaciones exitosas que demuestran el valor de Core OnBoarding en diferentes contextos y tamaños de empresa.

### Distribuidora Eléctrica Regional

*Material eléctrico — 45 usuarios, 3 sedes*

**Situación previa:** ERP legacy de 15 años, sin movilidad, informes manuales en Excel, 2 técnicos IT dedicados al mantenimiento.

**Implantación:** 10 semanas incluyendo migración de 180.000 artículos y 12.000 clientes.

**Resultados a 6 meses:**

| Métrica | Valor |
|---------|-------|
| Coste IT | **-55%** |
| Productividad admin. | **+30%** |
| Formación media | **2 días** |
| Caídas de servicio | **0** |

### Grupo de Fontanería Nacional

*Fontanería y clima — 120 usuarios, 8 sedes*

**Situación previa:** Dos ERPs diferentes (por adquisiciones), procesos duplicados, imposibilidad de consolidar datos entre empresas.

**Implantación:** 14 semanas con unificación de 4 empresas en un solo tenant multi-empresa.

**Resultados a 6 meses:**

| Métrica | Valor |
|---------|-------|
| Tiempo consolidación | **-45%** |
| Sistema para todo | **1 solo** |
| Ventas cruzadas | **+25%** |
| Personal admin. reasignado | **-3 FTEs** |

### Almacén de Construcción

*Construcción — 20 usuarios, 1 sede*

**Situación previa:** Software propio desarrollado hace 20 años por un informático que ya no está. Sin soporte, sin actualizaciones, sin documentación.

**Implantación:** 6 semanas. Empresa pequeña con procesos estándar.

**Resultados a 6 meses:**

| Métrica | Valor |
|---------|-------|
| Movilidad comercial | **100%** |
| Errores de pedido | **-70%** |
| Inversión inicial | **0€** |
| Soporte profesional | **Tranquilidad** |

### Climatización Industrial

*HVAC — 60 usuarios, 5 sedes*

**Situación previa:** SAP Business One con add-on de distribución. Coste de mantenimiento anual de €80K. Funcionalidades limitadas para sus necesidades.

**Implantación:** 12 semanas con migración completa desde SAP.

**Resultados a 6 meses:**

| Métrica | Valor |
|---------|-------|
| Coste anual ERP | **-60%** |
| Velocidad de pedidos | **+40%** |
| Reporting automático | **IA** |
| Satisfacción usuario | **4.8/5** |

### Testimonios

> "El asistente IA ha cambiado la forma de trabajar de mis comerciales. Lo que antes tardaban horas en Excel, ahora lo piden con una frase."
> — Director Comercial, Distribuidora Eléctrica

> "Por fin puedo ver las cifras de las 4 empresas del grupo en un solo dashboard, en tiempo real. Antes me hacían un informe mensual a mano."
> — CEO, Grupo de Fontanería Nacional

> "Nos ahorramos €48K/año solo en licencias SAP y mantenimiento. Y el sistema es mejor, más rápido y más fácil de usar."
> — CFO, Climatización Industrial

---

# 6. Implantación

## 6.1 Metodología

*(Contenido pendiente de desarrollo)*

## 6.2 Configuración inicial

*(Contenido pendiente de desarrollo)*

## 6.3 Migración de datos

*(Contenido pendiente de desarrollo)*

---

# 7. Stack Tecnológico

## 7.0 Visión general del pipeline

Proceso completo de CI/CD con GitOps para el despliegue de microservicios: desde el código fuente hasta producción, pasando por empaquetado Helm y sincronización con ArgoCD.

### Las 4 fases del pipeline

1. **Desarrollo** — Los desarrolladores hacen push al repositorio de microservicios. Tags y commits disparan distintos flujos de CI.
2. **Empaquetado** — GitHub Actions empaqueta Helm charts y los publica como paquetes OCI en registries dedicados.
3. **Despliegue** — ArgoCD detecta cambios en los charts y en el deployment repo, y sincroniza el estado con el cluster CORE.
4. **Operaciones** — El Control Panel permite gestionar versiones, actualizaciones de clientes, DNS y migraciones de base de datos.

### Tecnologías del pipeline

| Tecnología | Función |
|-----------|---------|
| **GitHub** | Repositorios & Actions |
| **Helm** | Empaquetado de charts |
| **OCI Registry** | Almacén de artefactos |
| **ArgoCD** | GitOps & despliegue |
| **PostgreSQL** | Base de datos |
| **Control Panel** | Gestión operativa |

### Diagrama de flujo completo

**Fase 1 — Desarrollo & CI:**
Dev → push → Repos Microservices → (tag / commit) → GitHub Actions (CI pipeline) → (values-dev.yaml / values.yaml) → Deployment Repo

**Fase 2 — Empaquetado Helm Charts:**
- Core Helm Repo → commit main → GitHub Actions → push package → OCI Registry (helm chart)
- Core Edge Repo → commit main → GitHub Actions → push package → OCI Registry (edge chart)

**Fase 3 — Despliegue con ArgoCD:**
OCI Registry (charts) + Deployment Repo (app config) → ArgoCD (GitOps sync) → CORE (producción)

**Fase 4 — Operaciones vía Control Panel:**
- User → Control Panel → Job → new version → Deployment Repo → ArgoCD → CORE
- User → Control Panel → Job → customer update → update DNS + PostgreSQL migrate

---

## 7.1 Desarrollo & CI

Los desarrolladores trabajan en los microservicios. Según el tipo de evento en Git, se disparan distintos workflows de GitHub Actions.

### Flujo por Tag

Cuando un desarrollador crea un **tag** en el repositorio de microservicios, se dispara el pipeline de CI que actualiza la configuración de desarrollo.

Dev → push tag → Repos Microservices → GitHub Actions → Deployment Repo

Genera `values-dev.yaml` en el deployment repo con la configuración de desarrollo.

### Flujo por Commit

Cuando se hace **push de un commit** al repositorio, se dispara el pipeline de CI que actualiza la configuración de producción.

Dev → push commit → Repos Microservices → GitHub Actions → Deployment Repo

Genera `values.yaml` en el deployment repo con la configuración de producción.

### Resumen del flujo

| Evento Git | Trigger | Acción CI | Resultado |
|-----------|---------|-----------|-----------|
| `push tag` | GitHub Actions | Build + push imagen + actualizar config | `values-dev.yaml` en Deployment Repo |
| `push commit` | GitHub Actions | Build + push imagen + actualizar config | `values.yaml` en Deployment Repo |

---

## 7.2 Empaquetado Helm Charts

Existen dos repositorios de charts Helm. Ambos flujos empaquetan y publican como paquetes OCI al hacer push a main.

### Core Helm Repo

Repositorio principal de charts Helm para los microservicios core de la plataforma.

Core Helm Repo → commit main → GitHub Actions → push package → OCI Registry

Los desarrolladores gestionan este repositorio con los charts de los servicios principales.

### Core Edge Repo

Repositorio de charts para componentes edge y servicios auxiliares. Gestionado por DevOps.

Core Edge Repo → commit main → GitHub Actions → push package → OCI Registry

**DevOps** gestiona el push al Core Edge Repo.

### Resumen del empaquetado

| Repositorio | Responsable | Trigger | Destino | Tipo de chart |
|-------------|-------------|---------|---------|---------------|
| **Core Helm Repo** | Desarrolladores | `commit main` | OCI Registry | Helm chart (servicios core) |
| **Core Edge Repo** | DevOps | `commit main` | OCI Registry | Edge chart (servicios auxiliares) |

---

## 7.3 Despliegue con ArgoCD

ArgoCD actúa como el orquestador GitOps. Consume charts de los OCI registries y la configuración del deployment repo para desplegar en CORE.

### Fuentes de datos de ArgoCD

- **OCI Registry (helm chart)** — Charts empaquetados del Core Helm Repo con las definiciones de los microservicios principales.
- **OCI Registry (edge chart)** — Charts del Core Edge Repo con los componentes auxiliares y de infraestructura.
- **Deployment Repo** — Configuración de la aplicación: values.yaml, variables de entorno y parámetros por cliente.

### Cómo funciona ArgoCD

| Concepto | Descripción |
|----------|-------------|
| **GitOps** | El estado deseado del cluster se define en Git. ArgoCD se encarga de que el cluster real coincida con lo declarado. |
| **Sincronización** | ArgoCD detecta cambios en los charts del OCI Registry o en el Deployment Repo y aplica las diferencias automáticamente. |
| **Rollback** | Si algo falla, se puede revertir al estado anterior simplemente apuntando a la versión correcta en Git. |
| **Cluster CORE** | El cluster de producción donde se despliegan todos los microservicios del ERP. |

---

## 7.4 Operaciones vía Control Panel

Los usuarios pueden realizar acciones operativas a través del Control Panel, que lanza Jobs automatizados para gestionar versiones, clientes y base de datos.

### Despliegue de nueva versión

Cuando hay una nueva versión disponible, el usuario la despliega desde el Control Panel.

User → Control Panel → new version → Job → Deployment Repo → ArgoCD → CORE

El Job actualiza el Deployment Repo con la nueva versión y ArgoCD sincroniza automáticamente el cluster.

### Actualización de cliente

Cuando se necesita actualizar un cliente específico, el proceso incluye actualización de DNS y migración de base de datos.

User → Control Panel → customer update → Job → Deployment Repo (update DNS) + PostgreSQL (migrate database)

### Acciones disponibles en el Control Panel

| Acción | Disparado por | Qué hace el Job | Sistemas afectados |
|--------|--------------|-----------------|-------------------|
| **Nueva versión** | Usuario / Admin | Actualiza la versión en el Deployment Repo | Deployment Repo → ArgoCD → CORE |
| **Actualización de cliente** | Usuario / Admin | Actualiza DNS + migra base de datos | Deployment Repo + PostgreSQL |

---

## 7.5 Tecnologías clave

Stack tecnológico utilizado en el pipeline de CI/CD y en la operación de la plataforma.

**GitHub** — Repositorios & Actions
- Plataforma central de gestión de código fuente. Aloja todos los repositorios de microservicios, charts Helm y configuración de despliegue.
- Repositorios de microservicios
- GitHub Actions para CI/CD
- Gestión de tags y releases
- Code review y pull requests

**Helm** — Empaquetado de charts
- Gestor de paquetes para Kubernetes. Permite definir, instalar y gestionar aplicaciones en el cluster de forma declarativa.
- Charts para microservicios core
- Charts para componentes edge
- Templating de configuración
- Versionado semántico

**OCI Registry** — Almacén de artefactos
- Registro de artefactos compatible con la especificación OCI. Almacena los charts Helm empaquetados listos para ser consumidos por ArgoCD.
- Almacén de Helm charts
- Imágenes de contenedores
- Versionado de artefactos
- Acceso seguro

**ArgoCD** — GitOps & despliegue
- Herramienta de entrega continua declarativa para Kubernetes. Implementa el patrón GitOps donde Git es la fuente de verdad.
- Sincronización automática con Git
- Detección de drift
- Rollback automático
- UI de visualización del cluster

**PostgreSQL** — Base de datos
- Sistema de gestión de bases de datos relacional. Motor principal de persistencia de datos del ERP.
- Base de datos por cliente
- Migraciones automatizadas
- Backups y recuperación
- Alta disponibilidad

**Control Panel** — Gestión operativa
- Panel de administración interno para gestionar el ciclo de vida de las instalaciones de clientes y las versiones del producto.
- Despliegue de nuevas versiones
- Actualización de clientes
- Gestión de DNS
- Migraciones de base de datos

### Mapa de repositorios

| Repositorio | Contenido | Gestionado por | Consume |
|-------------|-----------|----------------|---------|
| **Repos Microservices** | Código fuente de los microservicios | Desarrolladores | GitHub Actions (CI) |
| **Deployment Repo** | Configuración de despliegue (values.yaml) | CI + Control Panel | ArgoCD |
| **Core Helm Repo** | Charts Helm de servicios core | Desarrolladores | OCI Registry → ArgoCD |
| **Core Edge Repo** | Charts Helm de servicios edge | DevOps | OCI Registry → ArgoCD |

---

# 8. Observabilidad y Soporte

## 8.0 Visión general

En Core, cada acción, cada consulta, cada proceso queda registrado y trazado. Toda esa información se explota a través de Grafana, ofreciendo visibilidad total sobre lo que ocurre en la plataforma, usuario por usuario, tenant por tenant.

### La filosofía: si no se mide, no se puede mejorar

Core ha sido diseñado desde el día cero con observabilidad nativa. No es un añadido posterior: cada microservicio, cada endpoint, cada operación de negocio emite trazas, métricas y logs estructurados que se almacenan, indexan y quedan disponibles para su explotación.

Esto permite que cualquier departamento — soporte, consultoría, ventas, dirección — pueda tener respuestas basadas en datos reales sobre cómo se usa el producto, dónde hay cuellos de botella y qué clientes necesitan atención.

### Los pilares de la observabilidad en Core

- **Trazabilidad completa** — Cada petición atraviesa todos los microservicios con un ID de traza único. Desde el click del usuario hasta la respuesta final, todo queda registrado.
- **Grafana** — La plataforma de visualización donde toda la telemetría cobra sentido: dashboards, alertas, exploración y análisis en tiempo real.
- **Monitorización por tenant** — Cada cliente es un mundo. La monitorización por tenant permite ver el consumo, rendimiento y actividad de cada empresa de forma aislada.
- **Actividad de usuario** — Quién hizo qué, cuándo y desde dónde. Registro completo de actividad por usuario para auditoría, soporte y análisis de uso.
- **Diagnóstico y soporte** — Herramientas y metodología para que el equipo de soporte identifique y resuelva incidencias de forma rápida y eficaz.

### El flujo de la telemetría

Usuario (realiza acción) → Microservicio (procesa + emite trazas) → Collector (agrega telemetría) → Storage (métricas + logs + trazas) → Grafana (dashboards + alertas)

Toda acción del usuario genera telemetría que fluye automáticamente hasta los dashboards de Grafana.

### ¿Qué gana cada departamento?

| Departamento | Qué puede saber | Ejemplo práctico |
|-------------|-----------------|------------------|
| **Soporte** | Qué error vio el usuario, cuándo, qué request falló, qué microservicio respondió mal, con qué datos. | "El usuario X del tenant Y reporta que no puede crear pedidos desde las 10:15. Voy a Grafana y veo que el servicio de ventas está devolviendo 500 en ese tenant." |
| **Consultoría** | Qué módulos usa cada cliente, cuánto los usa, qué funcionalidades están infrautilizadas, dónde hay oportunidades. | "El cliente Z tiene el módulo de CRM pero solo ha creado 3 oportunidades en 2 meses. Deberíamos ofrecer formación." |
| **Ventas** | Datos reales de uso para argumentar: tiempos de respuesta, uptime, volumen de transacciones, adopción. | "Nuestros clientes procesan una media de 2.400 pedidos diarios con un tiempo de respuesta medio de 180ms." |
| **R&D** | Rendimiento real de cada servicio, cuellos de botella, queries lentas, patrones de uso, errores recurrentes. | "El endpoint de búsqueda de artículos supera los 500ms en tenants con más de 50K productos. Hay que optimizar." |
| **Dirección** | KPIs de plataforma: clientes activos, crecimiento de uso, SLA, tendencias, costes por tenant. | "Este trimestre hemos pasado de 45 a 62 tenants activos y el uptime ha sido del 99.97%." |

---

## 8.1 Trazabilidad completa

Cada acción en Core deja un rastro. Cada petición HTTP, cada operación de negocio, cada acceso a datos queda registrado con un identificador único que permite reconstruir exactamente qué pasó, cuándo, quién lo hizo y qué sistemas intervinieron.

### ¿Qué es una traza?

Una traza es el viaje completo de una petición a través del sistema. Cuando un usuario pulsa "Crear pedido", esa acción genera un **Trace ID** único que acompaña a la petición mientras viaja del frontend al API Gateway, de ahí al servicio de ventas, luego al servicio de stock, a la base de datos y vuelta. Cada paso es un **span** dentro de la traza, con su tiempo de inicio, duración, resultado y metadatos.

### Anatomía de una traza en Core

Trace ID: `abc-123-def-456` | Usuario: maria.lopez@cliente-demo.com | Tenant: cliente-demo

| Span | Operación | Componente | Tiempo |
|------|-----------|------------|--------|
| Span 1 | POST /api/v1/orders | API Gateway | 0ms — 245ms |
| Span 2 | OrderService.CreateOrder() | Servicio de Ventas | 12ms — 230ms |
| Span 3 | StockService.ReserveItems() | Servicio de Stock | 45ms — 120ms |
| Span 4 | INSERT INTO orders (...) | PostgreSQL | 130ms — 145ms |
| Span 5 | EventBus.Publish("OrderCreated") | Message Broker | 232ms — 238ms |

Resultado: 200 OK — Duración total: 245ms

### ¿Qué se registra en cada traza?

**Contexto del usuario:**
- ID de usuario y email
- Tenant al que pertenece
- Rol y permisos activos
- IP de origen y user-agent
- Sesión y dispositivo

**Contexto técnico:**
- Trace ID y Span ID (correlación distribuida)
- Servicio y versión que procesó la petición
- Método HTTP, endpoint, código de respuesta
- Tiempo de respuesta de cada componente
- Queries SQL ejecutadas y su duración

**Contexto de negocio:**
- Entidad afectada (pedido, cliente, artículo...)
- Operación realizada (crear, modificar, eliminar)
- Valores antes y después del cambio
- Reglas de negocio aplicadas
- Resultado funcional de la operación

**Errores y anomalías:**
- Stack trace completo del error
- Datos de entrada que provocaron el fallo
- Servicio y línea de código donde ocurrió
- Errores de validación y mensajes al usuario
- Timeouts, reintentos y circuit breakers activados

### Cumplimiento y auditoría

La trazabilidad no es solo una herramienta técnica. Es la base para cumplir con requisitos de auditoría, GDPR y regulaciones sectoriales. Cada dato modificado, cada acceso a información sensible, cada exportación de datos queda registrada con quién, cuándo y desde dónde. Esto permite generar informes de auditoría automáticos y responder con datos a cualquier solicitud de cumplimiento normativo.

---

## 8.2 Grafana

La plataforma de visualización que convierte toda la telemetría del sistema en dashboards accionables para cada equipo de la organización.

### ¿Qué es Grafana y por qué lo usamos?

Grafana es la plataforma open-source líder en observabilidad y visualización de datos. En Core, actúa como la **ventana única** donde cualquier persona de la organización puede consultar qué está pasando en el sistema en tiempo real.

No es una herramienta solo para técnicos. Los dashboards están diseñados para que **soporte, consultoría, ventas y dirección** puedan extraer la información que necesitan sin depender del equipo de desarrollo.

Cada interacción, cada proceso, cada error queda registrado y es consultable. Grafana es donde toda esa información cobra vida visual.

### Dashboards disponibles por equipo

**Soporte:**
- Errores en tiempo real por tenant
- Tiempos de respuesta por endpoint
- Usuarios activos por cliente
- Alertas de degradación de servicio
- Historial de incidencias por tenant

**Consultoría:**
- Uso de módulos por cliente
- Funcionalidades más/menos utilizadas
- Patrones de adopción post-implantación
- Comparativa de uso entre clientes
- Detección de oportunidades de formación

**Ventas / Dirección:**
- Métricas de adopción global
- SLAs cumplidos por cliente
- Crecimiento de uso (usuarios, transacciones)
- Health score por tenant
- ROI de funcionalidades implementadas

**Desarrollo / DevOps:**
- Rendimiento de microservicios
- Latencias P50/P95/P99
- Tasa de errores por servicio
- Consumo de recursos (CPU, RAM, disco)
- Despliegues y su impacto en métricas

**Seguridad / Compliance:**
- Intentos de acceso no autorizado
- Auditoría de cambios en datos sensibles
- Cumplimiento GDPR (accesos, exportaciones)
- Sesiones activas por ubicación
- Alertas de comportamiento anómalo

**Customer Success:**
- Engagement score por cliente
- Detección temprana de churn
- Evolución de uso mensual
- Nuevos usuarios vs activos vs inactivos
- Tickets vs satisfacción

### Stack de observabilidad integrado con Grafana

| Componente | Tecnología | Descripción |
|-----------|-----------|-------------|
| **Logs** | Loki / Promtail | Todos los eventos del sistema centralizados y consultables. |
| **Métricas** | Prometheus | Contadores, gauges e histogramas de todos los servicios. |
| **Traces** | Tempo / OpenTelemetry | Trazas distribuidas de cada petición end-to-end. |
| **Visualización** | Grafana | Dashboards unificados que consumen las tres fuentes. |

Logs + Métricas + Traces = Observabilidad completa, todo visible en Grafana

### Sistema de alertas

Grafana no solo muestra datos: genera alertas proactivas cuando algo requiere atención. El equipo de soporte puede actuar **antes de que el cliente reporte un problema**.

| Tipo de alerta | Ejemplo | Destinatario | Canal |
|---------------|---------|-------------|-------|
| **Crítica** | Servicio caído para un tenant > 2 min | DevOps + Soporte | Slack + PagerDuty |
| **Alta** | Tasa de error > 5% en un microservicio | DevOps | Slack + Email |
| **Media** | Latencia P95 > 3s en módulo de ventas | Desarrollo | Slack |
| **Informativa** | Tenant sin actividad en 7 días | Customer Success | Email resumen semanal |

### Filosofía de monitorización proactiva

El objetivo no es reaccionar a incidencias, sino detectarlas antes de que impacten al usuario. Grafana nos permite pasar de un soporte reactivo a uno predictivo, mejorando la calidad del servicio y la satisfacción del cliente.

---

## 8.3 Monitorización por tenant

Cada cliente (tenant) tiene su propio universo de datos aislado y monitorizable de forma independiente. Esto permite ofrecer un servicio personalizado y detectar problemas específicos sin ruido.

### ¿Qué significa monitorizar por tenant?

En una arquitectura multi-tenant como Core, cada cliente opera en un entorno lógicamente aislado. Esto significa que podemos **medir, trazar y alertar de forma independiente para cada uno**.

No es lo mismo que un cliente tenga un problema puntual a que haya una degradación general. La monitorización por tenant nos permite:

- **Identificar exactamente quién está afectado** sin asumir que un problema es global
- **Comparar métricas entre clientes** para detectar anomalías (¿por qué este cliente tiene 10x más errores?)
- **Ofrecer SLAs reales y medibles** con datos por cliente, no promedios globales
- **Planificar capacidad** cliente a cliente según su crecimiento real
- **Priorizar soporte** basándose en datos objetivos de impacto

### Ejemplo práctico

**Tenant: Electricidad López S.L.** — Estado: Saludable
- Usuarios activos: 23
- Latencia P95: 240ms
- Errores/h: 0.2

**Tenant: Fontanería García e Hijos** — Estado: Atención
- Usuarios activos: 8
- Latencia P95: 1.8s
- Errores/h: 12.4

Sin monitorización por tenant, estos dos clientes serían un promedio: todo parecería "normal".

### Métricas disponibles por tenant

**Rendimiento:**
- Tiempo de respuesta medio y percentiles (P50, P95, P99)
- Throughput (peticiones/segundo)
- Tiempo de carga de páginas principales
- Queries lentas específicas del tenant
- Consumo de recursos asignados

**Errores y fiabilidad:**
- Tasa de errores (4xx, 5xx) por módulo
- Errores de negocio (validaciones, conflictos)
- Disponibilidad efectiva (uptime por tenant)
- Intentos fallidos de operaciones críticas
- Degradaciones parciales (módulos lentos)

**Uso y adopción:**
- Usuarios activos diarios/semanales/mensuales
- Módulos más utilizados
- Funcionalidades nunca usadas (oportunidad de formación)
- Picos de uso (horarios, días de la semana)
- Evolución de uso mes a mes

**Datos y almacenamiento:**
- Volumen de datos almacenados
- Crecimiento de datos mensual
- Documentos/adjuntos subidos
- Registros creados por módulo
- Proyección de almacenamiento futuro

### Health Score del tenant

Cada tenant tiene un **Health Score** calculado automáticamente que resume en un solo indicador el estado general del servicio para ese cliente. Se alimenta de todas las métricas anteriores.

| Score | Estado | Significado | Acción |
|-------|--------|-------------|--------|
| 90-100 | Excelente | Todo funciona de forma óptima | Ninguna |
| 70-89 | Bueno | Rendimiento correcto, pequeñas áreas de mejora | Revisión en próximo ciclo |
| 50-69 | Atención | Degradación visible, posible impacto en usuario | Investigación proactiva |
| 0-49 | Crítico | Problemas serios afectando al cliente | Intervención inmediata |

### Ventaja competitiva real

La mayoría de ERPs del mercado no ofrecen visibilidad por cliente. Nosotros podemos demostrar con datos que cada tenant recibe un servicio de calidad, y actuar proactivamente cuando algo se degrada. Esto se traduce en menor churn, mayor satisfacción y un argumento de venta demoledor.

---

## 8.4 Actividad de usuario

Cada acción de cada usuario queda registrada. Esto permite entender cómo se usa el sistema, detectar problemas individuales, y ofrecer un soporte preciso y contextualizado.

### ¿Qué se registra de cada usuario?

- **Navegación** — Qué módulos visita, en qué orden, cuánto tiempo permanece en cada sección. Permite entender flujos de trabajo reales.
- **Operaciones** — Creaciones, ediciones, eliminaciones, aprobaciones. Toda operación de negocio con timestamp, datos anteriores y posteriores.
- **Búsquedas y consultas** — Qué busca el usuario, qué filtros aplica, qué informes genera. Revela necesidades de información no cubiertas.
- **Accesos y sesiones** — Inicio/cierre de sesión, dispositivo, ubicación, duración de sesión, intentos fallidos de acceso.
- **Errores encontrados** — Errores que ve el usuario, formularios que fallan, timeouts. Vinculados a su sesión específica para diagnóstico inmediato.
- **Exportaciones e informes** — Qué datos exporta, en qué formato, con qué frecuencia. Indicador de qué información es crítica para su día a día.

### Casos de uso prácticos

**Para Soporte:**

Cuando un usuario llama reportando un problema:
1. Buscar al usuario en Grafana
2. Ver su timeline de actividad de los últimos minutos
3. Identificar exactamente dónde ocurrió el error
4. Ver el trace completo de la petición que falló
5. Resolver o escalar con toda la información necesaria

Tiempo medio de diagnóstico: de **15-30 min** (preguntando al usuario) a **2-3 min** (consultando Grafana).

**Para Consultoría:**

Al preparar una sesión de seguimiento con el cliente:
1. Ver qué usuarios están activos y cuáles no
2. Identificar módulos infrautilizados
3. Detectar usuarios que usan workarounds innecesarios
4. Proponer formación específica basada en datos reales
5. Demostrar al cliente el valor que está obteniendo

Resultado: sesiones de seguimiento basadas en datos, no en suposiciones.

### Ejemplo: Timeline de actividad

**María García** — Electricidad López S.L. | Rol: Responsable de compras · Última sesión: hoy 10:34

- 10:34 — **Login** desde Chrome / Windows
- 10:35 — **Navegación** Módulo Compras → Pedidos pendientes
- 10:36 — **Consulta** Filtro: proveedor="SCHNEIDER" + estado="pendiente"
- 10:38 — **Operación** Aprobación pedido #4521 (3.240€)
- 10:39 — **Error** Intento de exportar PDF → timeout (3.2s)
- 10:40 — **Exportación** Reintento exitoso → descargado pedidos_pendientes.xlsx

### Privacidad y GDPR

Toda esta trazabilidad cumple con la normativa de protección de datos. Los datos de actividad se utilizan exclusivamente para la mejora del servicio, el soporte técnico y la auditoría de seguridad. Los clientes pueden solicitar la exportación o eliminación de sus datos en cualquier momento.

---

## 8.5 Diagnóstico y soporte

Cómo utilizar toda la infraestructura de observabilidad para resolver incidencias de forma rápida, precisa y documentada.

### Flujo de diagnóstico ante una incidencia

1. **Identificar tenant** — ¿Qué cliente reporta? ¿Qué usuario?
2. **Consultar Health Score** — ¿Es un problema aislado o sistémico?
3. **Ver timeline** — Actividad del usuario en ese momento
4. **Analizar trace** — Seguir la petición por todos los servicios
5. **Resolver o escalar** — Con toda la info, actuar o derivar
6. **Documentar** — Registrar causa, solución y prevención

### Catálogo de problemas frecuentes

| Síntoma reportado | Dónde mirar en Grafana | Causa habitual | Solución típica |
|-------------------|----------------------|----------------|-----------------|
| "Va muy lento" | Dashboard latencia del tenant → P95 por módulo | Query pesada, datos sin paginar, pico de uso concurrente | Identificar endpoint lento, optimizar query o escalar recursos |
| "Me da error al guardar" | Timeline del usuario → último error → trace completo | Validación de negocio, conflicto de concurrencia, timeout DB | Leer detalle del error en trace, corregir datos o reportar bug |
| "No puedo entrar" | Dashboard accesos → filtrar por usuario | Contraseña expirada, cuenta bloqueada, problema de IdP | Verificar estado de cuenta, desbloquear, verificar integración SSO |
| "No me salen datos" | Timeline del usuario → consultas ejecutadas → filtros aplicados | Filtros demasiado restrictivos, permisos insuficientes, datos no migrados | Revisar permisos del rol, verificar filtros, comprobar migración |
| "Ha desaparecido un registro" | Dashboard auditoría → buscar entidad por ID → historial de cambios | Eliminación por otro usuario, regla de negocio automática, error de sync | Consultar quién/cuándo/por qué se eliminó, restaurar si procede |
| "El informe no cuadra" | Dashboard operaciones → eventos del módulo afectado → datos procesados | Datos en estado transitorio, cálculo pendiente, caché desactualizada | Verificar estado de procesos batch, forzar recálculo si es necesario |

### Niveles de soporte y herramientas por nivel

**N1 — Soporte básico:**
Primer punto de contacto con el cliente. Resuelve incidencias comunes.
- Health Score del tenant
- Timeline de actividad del usuario
- Dashboard de errores recientes
- Estado de servicios (UP/DOWN)

**N2 — Soporte avanzado:**
Análisis en profundidad cuando N1 no puede resolver.
- Traces distribuidos completos
- Logs correlacionados
- Métricas de rendimiento por servicio
- Comparativa con otros tenants
- Auditoría de cambios en datos

**N3 — Ingeniería:**
Desarrollo interviene para bugs complejos o problemas de infraestructura.
- Dashboards de infraestructura (pods, nodos)
- Flame graphs de rendimiento
- Análisis de queries a DB
- Métricas de red y latencia entre servicios
- Logs de debug detallados

### KPIs del equipo de soporte (medidos en Grafana)

- **MTTR** — Tiempo medio de resolución. Objetivo: < 30 min para P1.
- **First Contact Resolution** — % de incidencias resueltas en N1. Objetivo: > 70%.
- **Detección proactiva** — % de problemas detectados antes de que el cliente reporte.
- **Satisfacción** — NPS del servicio de soporte. Objetivo: > 8/10.

### El soporte como ventaja competitiva

Con toda esta infraestructura de observabilidad, el equipo de soporte no es un centro de costes: es un diferenciador. Resolver rápido, resolver bien y resolver antes de que el cliente lo note es lo que genera fidelización y referencias.

---

# 9. Proveedor Cloud

## 9.0 Visión general — Google Cloud Platform

Toda la infraestructura de Core OnBoarding se aloja en **Google Cloud Platform (GCP)**, aprovechando su red global, servicios gestionados y certificaciones de seguridad para ofrecer un servicio fiable, escalable y seguro a todos los tenants.

### Capacidades principales

- **Infraestructura global** — Regiones y zonas distribuidas geográficamente, con conectividad de baja latencia y red privada de fibra de Google.
- **Kubernetes (GKE)** — Clusters gestionados con Google Kubernetes Engine: autoescalado, actualizaciones automáticas y alta disponibilidad.
- **Redundancia y HA** — Arquitectura multi-zona con failover automático, balanceo de carga global y SLAs de disponibilidad del 99.95%.
- **Copias de seguridad** — Backups automatizados, políticas de retención configurables y recuperación ante desastres con RPO y RTO definidos.
- **Seguridad cloud** — Cifrado en reposo y en tránsito, IAM granular, VPC privadas y cumplimiento normativo (ISO 27001, SOC 2, GDPR).
- **Escalabilidad** — Capacidad elástica: los recursos se ajustan automáticamente a la demanda, pagando solo por lo que se consume.

### ¿Por qué Google Cloud?

| Criterio | Valoración |
|----------|-----------|
| Red global privada | La más extensa del mundo, 40+ regiones |
| Kubernetes nativo | GKE es el servicio K8s más maduro del mercado |
| Precio/rendimiento | Descuentos por uso sostenido + committed use |
| Seguridad | Zero-trust, cifrado por defecto, BeyondCorp |
| Cumplimiento | ISO 27001, SOC 1/2/3, GDPR, ENS Alta |
| Soporte | Premium support con SLA de respuesta < 15 min (P1) |

**Región principal:** europe-west1 (Bélgica) — Baja latencia para clientes europeos.

**Región DR:** europe-west3 (Frankfurt) — Disaster Recovery con replicación asíncrona.

---

## 9.1 Infraestructura

La infraestructura de Core OnBoarding aprovecha la red global de Google para ofrecer baja latencia, alta disponibilidad y aislamiento de recursos entre tenants.

### Topología de red

Internet / Usuarios → Cloud Load Balancer (Global) → Cloud Armor (WAF + DDoS) → VPC Privada — GKE Cluster

**Componentes principales:**
- **VPC** — Red privada aislada
- **Subnets** — Segmentación por entorno
- **Cloud NAT** — Salida controlada
- **Cloud DNS** — Resolución privada
- **Firewall Rules** — Zero-trust
- **Private Google Access** — APIs sin Internet

### Servicios GCP utilizados

**Compute:**
- GKE (Kubernetes Engine)
- Cloud Run (jobs auxiliares)
- Compute Engine (bastion hosts)

**Datos:**
- Cloud SQL (PostgreSQL gestionado)
- Cloud Storage (objetos/blobs)
- Memorystore (Redis cache)

**Seguridad:**
- Cloud Armor (WAF)
- Secret Manager
- Cloud KMS (cifrado)

**Networking:**
- Cloud Load Balancing
- Cloud CDN
- Cloud Interconnect

**Observabilidad:**
- Cloud Logging
- Cloud Monitoring
- Cloud Trace

**DevOps:**
- Artifact Registry (imágenes)
- Cloud Build (CI opcional)
- Cloud Deploy (CD opcional)

### Entornos desplegados

| Entorno | Proyecto GCP | Región | Propósito |
|---------|-------------|--------|-----------|
| DEV | core-onboarding-dev | europe-west1 | Desarrollo y pruebas internas |
| STAGING | core-onboarding-stg | europe-west1 | Pre-producción, validación cliente |
| PROD | core-onboarding-prod | europe-west1 | Producción multi-tenant |
| DR | core-onboarding-dr | europe-west3 | Disaster Recovery (pasivo) |

---

## 9.2 Kubernetes (GKE)

Core OnBoarding se despliega sobre **GKE (Google Kubernetes Engine)**, el servicio gestionado de Kubernetes más maduro del mercado. GKE se encarga de la gestión del plano de control, actualizaciones de seguridad y autoescalado, permitiendo al equipo centrarse en el producto.

### Arquitectura del cluster

| Componente | Configuración |
|-----------|---------------|
| Tipo de cluster | Regional (multi-zona) |
| Versión K8s | Release channel: Stable |
| Node pools | System pool + Application pool + Jobs pool |
| Máquinas | e2-standard-4 (app) / e2-standard-8 (jobs) |
| Autoescalado | Cluster Autoscaler + HPA por deployment |
| Networking | VPC-native (alias IP) |
| Ingress | NGINX Ingress Controller + cert-manager |
| Service Mesh | Istio (opcional, para mTLS inter-servicio) |

**Namespaces:**

Cada tenant tiene su propio namespace con:
- ResourceQuotas (CPU, memoria)
- LimitRanges por pod
- NetworkPolicies de aislamiento
- ServiceAccount dedicado
- Secrets propios (cifrados con KMS)

### Workloads desplegados

- **API Backend** — Deployment con 3+ réplicas, HPA basado en CPU/requests. (Deployment / HPA / Service / Ingress)
- **Frontend SPA** — Servido desde Cloud CDN + bucket o NGINX pod. (Deployment / Service / Ingress)
- **Workers / Jobs** — CronJobs para tareas programadas y Jobs para procesos batch. (CronJob / Job / ConfigMap)
- **PostgreSQL** — Cloud SQL conectado vía Cloud SQL Auth Proxy (sidecar). (Sidecar / Secret / ServiceEntry)
- **Redis Cache** — Memorystore accesible desde la VPC, sin exposición pública. (ExternalName Service)
- **Monitoring Stack** — Prometheus + Grafana desplegados en namespace monitoring. (StatefulSet / DaemonSet / Service)

### Estrategia de despliegue

**Rolling Update:**

Actualización progresiva sin downtime:
- `maxSurge: 1` — máximo 1 pod extra durante el rollout
- `maxUnavailable: 0` — nunca menos pods de los deseados
- Readiness probes validan que el pod está listo antes de recibir tráfico
- Rollback automático si el health check falla

**Autoescalado:**

Dos niveles de escalado automático:
- **HPA** — Escala pods según CPU, memoria o métricas custom
- **Cluster Autoscaler** — Añade/elimina nodos según demanda de pods
- Pod Disruption Budgets para mantener mínimos durante mantenimiento
- Escalado predictivo opcional con métricas históricas

---

## 9.3 Redundancia y Alta Disponibilidad

La arquitectura de Core OnBoarding está diseñada para tolerar fallos a nivel de zona, nodo y pod, garantizando un SLA de disponibilidad del **99.95%** en producción.

### Niveles de redundancia

- **Multi-zona** — El cluster GKE se despliega en **3 zonas** dentro de la misma región. Si una zona cae, los pods se redistribuyen automáticamente.
- **Multi-nodo** — Cada servicio tiene mínimo **3 réplicas** distribuidas con `topologySpreadConstraints` para evitar concentración.
- **Multi-región (DR)** — Región secundaria en **europe-west3** (Frankfurt) con cluster en standby y réplica de datos asíncrona.

### Componentes de HA

| Capa | Solución | Failover |
|------|----------|----------|
| Load Balancer | Global HTTP(S) LB | Automático entre backends |
| Ingress | NGINX con múltiples réplicas | < 5 segundos |
| Aplicación | Deployments multi-réplica | Inmediato (K8s scheduler) |
| Base de datos | Cloud SQL HA (regional) | < 60 segundos (failover automático) |
| Cache | Memorystore HA (Standard Tier) | < 30 segundos |
| Storage | Cloud Storage (multi-regional) | Transparente |
| DNS | Cloud DNS (100% SLA) | Anycast global |

### Disaster Recovery

**Objetivos definidos:**

| Métrica | Valor |
|---------|-------|
| **RPO** (Recovery Point Objective) | ≤ 1 hora |
| **RTO** (Recovery Time Objective) | ≤ 4 horas |
| **Frecuencia de pruebas DR** | Trimestral |

**Procedimiento de failover:**
1. Detección de caída en región primaria (alertas automáticas)
2. Validación manual o automática del estado
3. Promoción del cluster DR a producción
4. Actualización de DNS global al nuevo endpoint
5. Verificación de integridad de datos
6. Notificación a clientes afectados

---

## 9.4 Copias de Seguridad y Recuperación

Se implementan múltiples niveles de backup para garantizar la integridad de los datos y la capacidad de restauración ante cualquier escenario de pérdida.

### Estrategia de backups

**Base de datos (Cloud SQL):**

| Concepto | Detalle |
|----------|---------|
| **Backups automáticos** | Diarios, ventana de 02:00-06:00 UTC |
| **Retención** | 30 días (automáticos) |
| **Point-in-Time Recovery** | Últimos 7 días con WAL logs |
| **Backups manuales** | Pre-release y pre-migración |
| **Replicación** | Cross-region a europe-west3 |

**Almacenamiento (Cloud Storage):**

| Concepto | Detalle |
|----------|---------|
| **Versionado** | Activado en todos los buckets |
| **Retención** | 90 días (versiones anteriores) |
| **Clase de storage** | Standard (activo) + Nearline (archivo) |
| **Replicación** | Dual-region (europe-west1 + west3) |
| **Object Lock** | Para backups críticos (inmutabilidad) |

### Backups de Kubernetes

**Velero + GCS:**

Se utiliza **Velero** para respaldar el estado del cluster:
- Backup diario de todos los recursos (deployments, configmaps, secrets, etc.)
- Almacenamiento en bucket dedicado con retención de 14 días
- Backup incremental de Persistent Volumes vía snapshots
- Restauración selectiva por namespace, recurso o label
- Pruebas de restauración mensuales en entorno de staging

> **Importante:** Los **Secrets** se respaldan cifrados con Cloud KMS. Las claves de cifrado tienen rotación automática cada 90 días.

### Política de retención

| Tipo | Frecuencia | Retención | Ubicación |
|------|-----------|-----------|-----------|
| DB — automático | Diario | 30 días | Misma región |
| DB — cross-region | Diario | 14 días | europe-west3 |
| DB — PITR (WAL) | Continuo | 7 días | Misma región |
| Storage — versionado | Por cambio | 90 días | Dual-region |
| K8s — Velero | Diario | 14 días | GCS bucket |
| K8s — PV snapshots | Diario | 7 días | Misma región |

### Pruebas de restauración

**Frecuencia:**
- **Mensual** — Restauración de DB en entorno aislado
- **Trimestral** — Simulacro completo de DR
- **Post-incidente** — Verificación tras cualquier fallo

**Métricas monitorizadas:**
- Tiempo de restauración efectivo vs RTO objetivo
- Integridad de datos post-restauración
- Tamaño y crecimiento de backups
- Alertas por backup fallido (< 5 min para resolver)

---

## 9.5 Seguridad Cloud

La seguridad en Google Cloud se aborda con un enfoque **Zero-Trust** y defensa en profundidad, con múltiples capas de protección desde la red hasta la aplicación.

### Capas de seguridad

**Perímetro:**
- Cloud Armor (WAF + anti-DDoS)
- Reglas IP geográficas
- Rate limiting por IP/tenant
- Certificados TLS gestionados

**Red:**
- VPC privada sin IPs públicas
- Firewall rules deny-all por defecto
- NetworkPolicies en K8s
- Private Google Access para APIs

**Identidad (IAM):**
- Principio de mínimo privilegio
- Service Accounts por workload
- Workload Identity para pods
- MFA obligatorio para humanos

**Cifrado:**
- En tránsito: TLS 1.3 obligatorio
- En reposo: AES-256 (Cloud KMS)
- CMEK (Customer-Managed Keys)
- Rotación automática de claves

**Contenedores:**
- Imágenes escaneadas (Artifact Analysis)
- Binary Authorization
- Pods non-root por defecto
- SecurityContext restrictivo

**Auditoría:**
- Audit Logs habilitados al 100%
- Data Access Logs activados
- Retención 400 días (Cloud Logging)
- Exportación a SIEM externo

### Cumplimiento normativo

| Certificación / Estándar | Alcance | Estado |
|-------------------------|---------|--------|
| ISO 27001 | Infraestructura GCP completa | Certificado |
| SOC 1 / SOC 2 / SOC 3 | Controles de seguridad y disponibilidad | Certificado |
| GDPR | Datos personales en región EU | Cumplimiento |
| ENS Alta | Esquema Nacional de Seguridad (España) | Certificado |
| PCI DSS | Si se procesan pagos | Opcional |

### Gestión de secretos

**Secret Manager + External Secrets Operator:**

Los secretos se gestionan centralizadamente:
1. Se almacenan en **Google Secret Manager** (cifrado con CMEK)
2. **External Secrets Operator** los sincroniza como K8s Secrets
3. Los pods acceden vía volúmenes montados o variables de entorno
4. Rotación automática sin reinicio de pods (watch mode)
5. Acceso auditado — cada lectura queda registrada en Audit Logs

**Buenas prácticas:**
- Nunca secretos en código o Git
- Nunca secretos en variables CI
- Rotación cada 90 días máx.
- Alertas por acceso no esperado

---

# 10. Inteligencia Artificial

## 10.0 Visión general

Core OnBoarding integra **agentes de IA conversacionales** que permiten a los usuarios realizar operaciones complejas usando **lenguaje natural**. No se necesitan conocimientos técnicos: basta describir lo que se quiere hacer y el agente lo ejecuta.

### Capacidades IA integradas

- **Cambios masivos** — Modifica miles de registros a la vez describiendo la operación en lenguaje natural. El agente interpreta, valida y ejecuta.
- **Widgets y gráficos** — Crea dashboards personalizados pidiendo al agente el gráfico que necesitas. Se genera al instante sin programar.
- **Reports y formularios** — Diseña informes y formularios describiendo la estructura, campos y formato que necesitas. El agente lo construye por ti.
- **Diseño de filtros** — Configura filtros avanzados en cualquier vista simplemente describiendo los criterios que necesitas aplicar.
- **MCP** — Model Context Protocol: el estándar abierto que permite a los agentes IA conectarse con las herramientas y datos del ERP de forma segura.

**Filosofía:** "Si puedes describirlo, el sistema puede hacerlo."

### ¿Cómo funciona?

1. **El usuario describe la acción** — "Sube un 5% el precio de todos los productos de la familia Fontanería que lleven más de 6 meses sin venta"
2. **El agente interpreta y planifica** — Analiza la petición, identifica los registros afectados y propone un plan de ejecución.
3. **Validación y confirmación** — Muestra un resumen: "Se van a modificar 342 productos. ¿Confirmas?" — El usuario aprueba o ajusta.
4. **Ejecución controlada** — Se aplica el cambio con trazabilidad completa, opción de rollback y log de auditoría.

### Seguridad

- Los agentes respetan los permisos del usuario
- No se ejecuta nada sin confirmación explícita
- Cada acción queda en el log de auditoría
- Rollback disponible para operaciones masivas
- Los datos nunca salen del sistema

---

## 10.1 Cambios Masivos con Agentes IA

Modifica miles de registros de una sola vez simplemente **describiendo en lenguaje natural** qué quieres cambiar. El agente interpreta tu petición, localiza los registros afectados, te muestra una previsualización y ejecuta el cambio con trazabilidad completa.

### Ejemplos de uso

**Actualización de precios:**
> "Sube un 3% todos los artículos de la tarifa PVP cuyo proveedor sea Schneider y que no se hayan modificado en los últimos 60 días"

El agente identifica 1.247 artículos, muestra ejemplo de antes/después y pide confirmación.

**Reclasificación:**
> "Mueve todos los clientes de la zona Norte que facturen menos de 5.000€/año a la categoría C y asígnalos al comercial Pedro García"

El agente detecta 89 clientes, desglosa el impacto en cartera y solicita validación.

**Corrección de datos:**
> "Pon el campo 'país' a 'España' en todos los proveedores que tengan código postal entre 01000 y 52999 y el país esté vacío"

El agente localiza 56 proveedores con el campo vacío y los corrige en bloque.

**Activación / Desactivación:**
> "Desactiva todos los artículos que no hayan tenido movimiento de stock ni ventas en los últimos 18 meses"

El agente analiza histórico, identifica 2.340 artículos "muertos" y propone la baja.

### Flujo de ejecución

Prompt (Usuario describe) → Análisis (Agente interpreta) → Preview (Muestra impacto) → Confirma (Usuario aprueba) → Ejecuta (Aplicación + log)

### Garantías

- **Rollback** — Cada operación masiva se puede deshacer al completo.
- **Auditoría** — Log detallado de qué se cambió, por quién y cuándo.
- **Permisos** — Solo ejecuta lo que el usuario tiene permitido hacer.
- **Límites** — Umbrales configurables para evitar cambios accidentales.

---

## 10.2 Widgets y Gráficos con Agentes IA

Los usuarios pueden crear **dashboards personalizados** y visualizaciones de datos simplemente pidiendo al agente lo que necesitan ver. Sin configuraciones complejas, sin conocimientos técnicos.

### Ejemplos de peticiones

> "Hazme un gráfico de barras con las ventas mensuales del último año comparado con el anterior"

Genera un bar chart comparativo con doble serie temporal.

> "Quiero un widget con el top 10 de clientes por facturación este trimestre, con un pie chart"

Crea un widget de ranking con gráfico circular interactivo.

> "Muéstrame la evolución del stock valorado por familia de producto, en formato línea temporal"

Genera un line chart multi-serie con filtro por familia.

> "Ponme un KPI grande con el margen medio de este mes y una flecha que indique si sube o baja respecto al mes pasado"

Crea un widget KPI con indicador de tendencia.

### Tipos de visualización soportados

- Barras
- Líneas
- Circular
- KPIs
- Tablas
- Mapas

### Características

**Personalización total:**
- Colores, tamaños y disposición configurables por voz
- Widgets arrastrables y redimensionables
- Dashboards privados o compartidos por equipo/rol
- Datos en tiempo real con refresco automático

**Iteración natural:**
- "Cámbialo a gráfico circular" — Cambia tipo al instante
- "Añade el año anterior para comparar" — Agrega serie
- "Filtra solo la delegación de Madrid" — Aplica filtro
- "Ponlo más grande y en la parte de arriba" — Reubica

---

## 10.3 Reports y Formularios con Agentes IA

Diseña informes y formularios personalizados **describiendo lo que necesitas**. El agente construye la estructura, selecciona los campos, aplica formatos y genera el resultado listo para usar o exportar.

### Informes bajo demanda

**Ejemplo: Informe comercial:**
> "Hazme un informe con las ventas por comercial de este trimestre, agrupado por zona, con totales y porcentaje sobre objetivo"

El agente genera un report tabular con agrupaciones, subtotales y columna calculada de % objetivo.

**Ejemplo: Listado de stock:**
> "Necesito un listado de artículos con stock por debajo del mínimo, ordenado por urgencia, con datos de proveedor y último precio de compra"

Genera un informe operativo con semáforo de urgencia y datos cruzados de compras.

### Diseño de formularios

**Ejemplo: Formulario de alta:**
> "Crea un formulario de alta de cliente con: razón social, CIF, dirección, persona de contacto, email, teléfono, condiciones de pago y límite de crédito"

El agente genera un formulario estructurado en secciones con validaciones automáticas.

**Ejemplo: Checklist:**
> "Necesito un formulario tipo checklist para la recepción de mercancía: estado del embalaje, cantidad recibida vs pedida, albarán conforme, incidencias"

Crea un formulario con checkboxes, campos condicionales y captura de foto de incidencias.

### Capacidades del generador

**Exportación:**
- PDF con formato profesional
- Excel con fórmulas activas
- CSV para integración
- Envío por email programado

**Programación:**
- "Envíame este informe cada lunes"
- Ejecución periódica automática
- Alertas si un KPI supera umbral
- Histórico de ejecuciones

**Parámetros dinámicos:**
- Filtros de fecha, comercial, zona...
- El usuario elige al ejecutar
- Valores por defecto inteligentes
- Guardado como plantilla reutilizable

---

## 10.4 Diseño de Filtros con Agentes IA

En cualquier listado o vista del ERP, el usuario puede **describir en lenguaje natural** los criterios de filtrado que necesita. El agente traduce la petición a filtros estructurados y los aplica al instante.

### Ejemplos de filtrado natural

**Vista de clientes:**
> "Muéstrame solo los clientes de Barcelona que compren más de 50.000€/año y tengan alguna factura pendiente"

Aplica: provincia = Barcelona AND facturación anual > 50K AND saldo pendiente > 0.

**Vista de artículos:**
> "Filtra los artículos de la familia Climatización con stock bajo mínimo y que tengan pedido de compra en curso"

Aplica: familia = Climatización AND stock < stock_min AND pedido_compra_activo = true.

**Vista de pedidos:**
> "Quiero ver los pedidos de esta semana que superen los 2.000€ y no estén expedidos"

Aplica: fecha >= lunes AND importe > 2000 AND estado != expedido.

**Vista de proveedores:**
> "Proveedores internacionales con plazo de entrega mayor a 15 días y que no hayan servido en los últimos 3 meses"

Aplica: país != España AND lead_time > 15 AND última_recepción < hace 3 meses.

### Funcionalidades

**Filtros guardados:**
- "Guárdame este filtro como *Clientes VIP morosos*"
- Acceso rápido desde un selector de filtros guardados
- Compartir filtros con el equipo
- Filtros privados o públicos por rol

**Refinamiento iterativo:**
- "Añade también los de Valencia" — Amplía criterio
- "Quita los que facturen menos de 10K" — Restringe
- "Ordénalos por fecha de último pedido" — Cambia orden
- "Muéstrame solo las columnas nombre, ciudad y saldo" — Ajusta vista

### Ventajas frente a filtros tradicionales

| Aspecto | Filtros tradicionales | Filtros con IA |
|---------|----------------------|----------------|
| Curva de aprendizaje | Media — hay que conocer los campos | Nula — se describe en lenguaje natural |
| Combinaciones complejas | Difícil — múltiples selectores | Fácil — una frase lo resuelve |
| Campos calculados | No disponible sin desarrollo | El agente los genera al vuelo |
| Velocidad | Varios clics y selecciones | Una frase, resultado inmediato |
| Reutilización | Manual (guardar configuración) | "Guárdamelo como..." y listo |

---

## 10.5 MCP — Model Context Protocol

El **Model Context Protocol (MCP)** es el estándar abierto que permite a los modelos de IA (LLMs) conectarse de forma segura y estructurada con herramientas externas, APIs y fuentes de datos. Es la capa que hace posible que los agentes IA de Core OnBoarding interactúen con el ERP.

### ¿Qué es MCP?

MCP es un protocolo creado por **Anthropic** (creadores de Claude) que define cómo los modelos de lenguaje pueden:

- **Descubrir** herramientas disponibles (tools)
- **Invocar** funciones del sistema con parámetros correctos
- **Recibir** resultados estructurados para continuar el razonamiento
- **Acceder** a datos contextuales (resources) del entorno

Es el equivalente a un *"USB universal"* para conectar IA con cualquier sistema.

Modelo IA (LLM) ↔ MCP Protocol ↔ Core OnBoarding (ERP)

### Arquitectura MCP en Core OnBoarding

**Tools (Herramientas)** — Acciones que el agente puede ejecutar:

| Tool | Descripción |
|------|-------------|
| `search_products` | Buscar artículos con filtros |
| `update_records` | Modificar registros en bloque |
| `create_report` | Generar informe bajo demanda |
| `get_dashboard_data` | Obtener datos para widgets |
| `apply_filter` | Aplicar filtros a una vista |
| `execute_workflow` | Lanzar un flujo de trabajo |

**Resources (Contexto)** — Datos que el agente puede consultar para razonar:

| Resource | Descripción |
|----------|-------------|
| `schema://products` | Estructura del catálogo |
| `schema://customers` | Modelo de clientes |
| `config://business_rules` | Reglas de negocio activas |
| `context://current_user` | Permisos del usuario activo |
| `context://active_view` | Vista actual y sus columnas |

### Seguridad del protocolo

- **Autenticación** — El agente hereda los permisos del usuario que lo invoca.
- **Scope limitado** — Solo puede acceder a tools/resources autorizados para ese rol.
- **Auditoría** — Cada invocación MCP queda registrada con parámetros y resultado.
- **Sandboxing** — Ejecución aislada: el agente no puede saltarse validaciones del sistema.

### Ventajas de MCP

| Ventaja | Descripción |
|---------|-------------|
| **Estándar abierto** | No depende de un proveedor de IA concreto. Compatible con Claude, GPT, Gemini, Llama, etc. |
| **Extensible** | Añadir nuevas capacidades al agente = añadir un nuevo tool al servidor MCP. |
| **Seguro por diseño** | El modelo nunca tiene acceso directo a la base de datos; pasa siempre por el servidor MCP. |
| **Tipado y validado** | Cada tool define su schema JSON: parámetros obligatorios, tipos, validaciones. |
| **Composable** | El agente puede encadenar múltiples tools en una sola conversación para tareas complejas. |

---

# 11. Bancos de Datos

## 11.0 Visión general

Core OnBoarding se integra con los principales bancos de datos del sector para mantener el catálogo de productos **actualizado diariamente** con la información publicada por los fabricantes: tarifas, descripciones, imágenes, fichas técnicas y datos logísticos.

### Fuentes de datos integradas

**eDam / Electronet** — Base de datos del sector electrotécnico creada conjuntamente por más de 200 fabricantes y distribuidores. Estándar del sector eléctrico en España.
- Material eléctrico, iluminación, automatización
- Formato estandarizado BMEcat
- Actualización directa del fabricante sin intermediarios

**GO!Catalog** — Más de 6 millones de referencias de 1.200+ marcas. Catálogo de referencia para fontanería, climatización, construcción y también electricidad.
- Fontanería, climatización, construcción, electricidad
- Operado por Telematel (desde 1988)
- Usado por +2.000 distribuidores profesionales

### Proceso de actualización diaria

Descarga (03:00 AM) → Normalización (Parsing + ETIM) → Comparación (Detecta cambios) → Aplicación (Actualiza catálogo) → Notificación (Alerta al usuario)

### ¿Qué se actualiza?

- **Tarifas PVP** — Precios de tarifa del fabricante actualizados al día.
- **Imágenes** — Fotos de producto, esquemas y planos técnicos.
- **Fichas técnicas** — PDFs, manuales y documentación del fabricante.
- **Datos logísticos** — EAN, peso, volumen, unidades de embalaje.

### Beneficios para el distribuidor

| Sin integración | Con Core OnBoarding |
|----------------|---------------------|
| Actualización manual de tarifas (días de trabajo) | Automático cada noche, sin intervención |
| Errores de precio por tarifas desactualizadas | Siempre al día con el fabricante |
| Catálogo sin imágenes ni fichas | Contenido rico descargado automáticamente |
| Alta manual de nuevos productos | Nuevas referencias disponibles al día siguiente |
| Productos descatalogados sin detectar | Alerta automática de descatalogación |

---

## 11.1 eDam / Electronet

**Electronet** es la base de datos de referencia del sector electrotécnico en España, creada y mantenida conjuntamente por más de **200 fabricantes y distribuidores**. Es el estándar de facto para el intercambio de información de producto en el sector eléctrico.

### ¿Qué es Electronet?

Electronet es una plataforma colaborativa donde los fabricantes de material eléctrico publican directamente su catálogo de productos sin intermediarios. Los distribuidores acceden a esta información para mantener sus sistemas actualizados.

| Concepto | Detalle |
|----------|---------|
| **Sector** | Material eléctrico, iluminación, automatización industrial |
| **Fabricantes** | +200 (Schneider, Legrand, ABB, Philips, Siemens...) |
| **Formato** | BMEcat (estándar europeo de catálogo electrónico) |
| **Clasificación** | ETIM (European Technical Information Model) |
| **Actualización** | Directa por el fabricante, sin intermediarios |
| **Acceso** | Web (sin instalación), API para integración |

**Contenido por producto:**
- Referencia del fabricante
- Descripción corta y larga
- Tarifa PVP vigente
- Códigos EAN / GTIN
- Clasificación ETIM (atributos técnicos)
- Imágenes de producto
- Fichas técnicas (PDF)
- Datos logísticos (peso, embalaje)
- Estado: activo / descatalogado / sustituto
- Producto sustituto recomendado

### Integración con Core OnBoarding

**Sincronización automática:**

Proceso nocturno (03:00 AM) que ejecuta:
1. Conexión al servicio Electronet vía API BMEcat
2. Descarga incremental de cambios desde última sincronización
3. Parsing y normalización al modelo de datos de Core
4. Detección de cambios: nuevos productos, modificaciones de tarifa, descatalogaciones
5. Aplicación automática según reglas configuradas por el distribuidor
6. Generación de informe de cambios para revisión

**Reglas configurables:**

El distribuidor define cómo se aplican los cambios:
- **Tarifas:** Aplicar automáticamente / Requiere aprobación / Solo notificar
- **Nuevos productos:** Alta automática / Cola de revisión
- **Descatalogados:** Desactivar auto / Marcar para revisión
- **Imágenes:** Siempre actualizar / Solo si no tiene propia
- **Sustituciones:** Notificar a comerciales afectados

### Marcas principales disponibles

Schneider Electric, Legrand, ABB, Siemens, Philips Lighting, Hager, General Electric, Gewiss, Simon, Circutor, Weidmüller, Phoenix Contact

---

## 11.2 GO!Catalog

**GO!Catalog** es la base de datos cloud de referencia para el sector de instalación y construcción, operada por **Telematel** desde 1988. Contiene más de **6 millones de referencias** de más de **1.200 marcas**, utilizada por más de 2.000 distribuidores profesionales en España.

### Cobertura sectorial

- Fontanería
- Climatización
- Construcción
- Electricidad
- Iluminación
- Comunicaciones
- Herramientas
- Baño y cocina

### Datos por producto

| Tipo de dato | Descripción |
|-------------|-------------|
| **Tarifas PVP** | Precio vigente del fabricante, actualizadas diariamente |
| **Descripciones** | Corta, larga y comercial, en múltiples idiomas |
| **Imágenes** | Fotos HD, vistas múltiples, imágenes de ambiente |
| **Fichas técnicas** | PDFs, instrucciones de montaje, certificados |
| **Características ETIM** | Atributos técnicos normalizados (diámetro, potencia, material...) |
| **Datos logísticos** | Peso, volumen, unidades por embalaje, paletización |
| **Multimedia** | Vídeos, modelos 3D, DWG/BIM para proyectos |
| **Códigos** | EAN, referencia fabricante, código ETIM, código UNSPSC |

### Cifras clave

- **6.000.000+** referencias
- **1.200+** marcas
- **2.000+** distribuidores conectados
- **800.000+** actualizaciones/mes
- **40.000+** productos actualizados/día
- **11** categorías de producto

### Integración con Core OnBoarding

**Conexión vía API:**

GO!Catalog ofrece API de integración en formatos:
- **CSV** — Importación masiva batch
- **XML** — Formato BMEcat estándar
- **JSON** — API REST moderna para tiempo real

Core OnBoarding utiliza la API JSON para sincronización incremental diaria y la API REST para consultas puntuales en tiempo real.

**Proceso de sincronización:**
- **04:00 AM** — Descarga delta de cambios de las últimas 24h
- **04:15 AM** — Normalización y mapeo al catálogo del distribuidor
- **04:30 AM** — Aplicación de reglas (auto-aplicar, revisar, notificar)
- **05:00 AM** — Descarga de imágenes y documentos nuevos
- **06:00 AM** — Informe de sincronización disponible para revisión
- **Tiempo real** — Consulta de stock/precio fabricante bajo demanda

### Distribuidores que usan GO!Catalog

Fegime, ABM Rexel, Cealco, Sonepar, AÚNA Distribución, Saltoki, Grupo Cobber, Comafe, Cecoa, BigMat

---

# 12. Despliegue y Versiones

## 12.0 Visión general

Core OnBoarding utiliza una estrategia de despliegue **Blue / Green** con dos entornos de producción permanentes que alojan versiones alternas de la plataforma. Este modelo garantiza actualizaciones sin downtime, rollback inmediato y un control total sobre qué versión ejecuta cada cliente.

### Principios del modelo

- **Dos entornos de producción** — Blue y Green funcionan simultáneamente, cada uno con una versión distinta de la plataforma.
- **Versiones alternas** — Las dos últimas versiones publicadas siempre están desplegadas: una en Blue y otra en Green.
- **Actualización controlada** — Cada cliente decide cuándo migrar a la siguiente versión desde el Panel de Control.
- **Zero downtime** — La actualización del cliente es un cambio de DNS + migración de BD, sin parada de servicio.

### Flujo general

```
Versión N   → desplegada en Blue
Versión N+1 → desplegada en Green

Cliente en v.N (Blue) → actualiza → migra BD + DNS → pasa a v.N+1 (Green)

Cuando llega v.N+2:
  - Se despliega en Blue (reemplazando v.N)
  - Green sigue con v.N+1
  - Los clientes en v.N+1 pueden actualizar a v.N+2
```

### Ventajas del modelo

| Ventaja | Descripción |
|---------|-------------|
| **Zero downtime** | El entorno destino ya está en marcha; el cliente solo cambia de destino |
| **Rollback inmediato** | Si algo falla, basta con revertir el DNS al entorno anterior |
| **Coexistencia de versiones** | Clientes en distintas versiones conviven sin conflicto |
| **Validación previa** | El nuevo entorno se puede verificar antes de mover clientes |
| **Simplicidad operativa** | Solo dos entornos fijos; no se crean ni destruyen dinámicamente |

---

## 12.1 Entornos Blue / Green

Los dos entornos de producción son clusters independientes con su propia infraestructura, configuración y versión desplegada.

### Características de cada entorno

| Aspecto | Blue | Green |
|---------|------|-------|
| **Infraestructura** | Cluster Kubernetes dedicado | Cluster Kubernetes dedicado |
| **Versión** | Versión N o N+2 (alterno) | Versión N+1 o N+3 (alterno) |
| **Bases de datos** | Instancias PostgreSQL propias | Instancias PostgreSQL propias |
| **DNS** | `*.blue.core.com` (interno) | `*.green.core.com` (interno) |
| **Estado** | Siempre activo | Siempre activo |

### Ciclo de vida de los entornos

1. **Estado inicial** — Blue ejecuta la versión N, Green ejecuta la versión N+1.
2. **Nueva versión disponible (N+2)** — Se despliega en Blue, reemplazando la versión N. Los clientes que aún estuvieran en v.N ya habrán sido migrados previamente a v.N+1.
3. **Siguiente versión (N+3)** — Se despliega en Green, reemplazando v.N+1. Y así sucesivamente.

Los entornos se van alternando: Blue recibe las versiones pares del ciclo, Green las impares (o viceversa, según el punto de partida).

### Aislamiento

- Cada entorno tiene su propio cluster de Kubernetes, servicios, ingress y certificados.
- Las bases de datos de los tenants están asociadas al entorno donde se ejecutan; al migrar un tenant se mueve o conecta su BD al entorno destino.
- Los buckets de almacenamiento (Gestión Documental) son compartidos y no cambian con la versión.

---

## 12.2 Gestión de versiones

Desde el **Panel de Control** (BackOffice), el equipo de operaciones mantiene un registro de versiones disponibles y controla qué versión está desplegada en cada entorno.

### Mantenimiento de versiones

El panel incluye una sección de **mantenimiento de versiones** donde se registran las releases de la plataforma:

| Campo | Descripción |
|-------|-------------|
| **Número de versión** | Identificador de la release (ej: `2026.3.0`) |
| **Entorno asignado** | Blue o Green |
| **Estado** | Preparada, Desplegada, Retirada |
| **Fecha de despliegue** | Cuándo se desplegó en el entorno |
| **Changelog** | Resumen de cambios, mejoras y correcciones |
| **Migraciones de BD** | Scripts de migración incluidos en esta versión |

### Reglas del sistema

- Las **dos últimas versiones** siempre están desplegadas: una en Blue y otra en Green.
- Cuando se registra una nueva versión, se despliega en el entorno que tiene la versión **más antigua**, liberándolo.
- No se puede retirar una versión si aún hay tenants ejecutándola.
- El panel muestra en todo momento cuántos tenants hay en cada versión/entorno.

### Visibilidad

Desde el panel se puede consultar:

- Qué versión ejecuta cada entorno
- Cuántos tenants hay en cada versión
- Qué tenants tienen actualización disponible
- Historial de versiones desplegadas

---

## 12.3 Proceso de actualización de clientes

La actualización de un cliente (tenant) a una nueva versión se inicia desde el **mantenimiento de bases de datos** en el Panel de Control.

### Campo de versión en bases de datos

En la ficha de cada base de datos / tenant existe un campo **Versión** que indica en qué versión está operando actualmente. Cuando existe una versión superior disponible, aparece un **botón "Actualizar a la siguiente versión"**.

### Flujo de actualización

Al pulsar el botón de actualización se ejecuta el siguiente proceso automatizado:

**1. Validación previa**
- Comprobar que la versión destino está desplegada y operativa en su entorno
- Verificar que no hay procesos críticos en curso en el tenant (cierres contables, facturaciones masivas, etc.)
- Confirmar que las migraciones de BD para esa versión están disponibles

**2. Migración de base de datos**
- Ejecutar los scripts de migración de esquema correspondientes a la nueva versión
- Aplicar transformaciones de datos si las hubiera
- Verificar la integridad de la migración

**3. Redirección DNS**
- Modificar los registros DNS de todos los subdominios del tenant para que apunten al nuevo entorno (de Blue a Green o viceversa)
- El cambio de DNS es transparente para el usuario; al recargar la página ya está en la nueva versión

**4. Verificación post-migración**
- Comprobar que el tenant responde correctamente en el nuevo entorno
- Validar acceso a datos, configuración y servicios
- Registrar la actualización en el log de auditoría

### Diagrama del proceso

```
Tenant "ABC" en v.2026.2 (Blue)
         │
         ▼
  [Botón: Actualizar a v.2026.3]
         │
         ▼
  ┌─ Validación previa ─┐
  │  • Entorno Green OK  │
  │  • Sin procesos bloq.│
  │  • Migraciones listas│
  └──────────┬───────────┘
             ▼
  ┌─ Migración de BD ───┐
  │  • Ejecutar scripts  │
  │  • Transformar datos │
  │  • Verificar integr. │
  └──────────┬───────────┘
             ▼
  ┌─ Cambio de DNS ─────┐
  │  abc.core.com ──────►│
  │  Blue → Green        │
  └──────────┬───────────┘
             ▼
  ┌─ Verificación ──────┐
  │  • Respuesta OK      │
  │  • Datos accesibles  │
  │  • Log de auditoría  │
  └──────────────────────┘
         │
         ▼
Tenant "ABC" en v.2026.3 (Green) ✓
```

### Consideraciones

- **Reversibilidad** — Si la verificación falla, el proceso revierte automáticamente: restaura la BD y devuelve el DNS al entorno original.
- **Ventana de mantenimiento** — La migración se puede programar para ejecutarse en horario de bajo uso, aunque el proceso típico dura menos de 5 minutos.
- **Notificación al cliente** — El sistema puede enviar un aviso previo al administrador del tenant informando de la actualización planificada.
- **Actualización por lotes** — El panel permite seleccionar múltiples tenants y actualizar en lote, ejecutando el proceso secuencialmente para cada uno.

---

# 13. FinOps

## 13.0 FinOps en Core

**FinOps (Financial Operations)** es la práctica que une ingeniería, finanzas y negocio para gestionar de forma colaborativa el coste de la infraestructura cloud, maximizando el valor obtenido por cada euro invertido.

### ¿Qué es FinOps?

En un modelo cloud como el de Core OnBoarding (Google Cloud + Kubernetes), los costes de infraestructura son **variables y elásticos**: crecen y decrecen según el uso. FinOps establece las prácticas para:

- **Visibilizar** — Saber exactamente cuánto cuesta cada componente, servicio y tenant
- **Optimizar** — Eliminar desperdicio, dimensionar correctamente, usar descuentos
- **Operar** — Tomar decisiones de ingeniería con consciencia de coste

**Los 3 pilares:** Informar | Optimizar | Operar

### ¿Por qué FinOps en Core OnBoarding?

Core OnBoarding opera en **Google Cloud con Kubernetes (GKE)**, ejecutando una plataforma multitenant que sirve a múltiples clientes sobre infraestructura compartida. El coste de esa infraestructura se reparte entre todos los tenants. FinOps nos permite saber **cuánto cuesta servir a cada cliente**, optimizar los recursos y trasladar ese ahorro al precio final.

### Beneficios para la organización

**Visibilidad total de costes:**
- Coste desglosado por servicio GCP (GKE, Cloud SQL, Storage, etc.)
- Coste atribuido por tenant / cliente
- Coste por entorno (Dev, Staging, Producción)
- Evolución temporal y tendencias
- Alertas cuando un coste se desvía del presupuesto

**Optimización continua:**
- Right-sizing de nodos y pods (no sobredimensionar)
- Committed Use Discounts (GCP) para carga base
- Spot/preemptible nodes para jobs no críticos
- Autoescalado inteligente (escalar hacia abajo también)
- Limpieza de recursos huérfanos (discos, IPs, snapshots)

**Margen predecible:**
- Saber el coste real de servir a cada cliente
- Pricing basado en datos, no en estimaciones
- Detectar clientes con coste desproporcionado
- Presupuestos mensuales con tracking automático
- Previsión de costes ante crecimiento de clientes

**Cultura de responsabilidad:**
- Ingeniería decide con consciencia de coste
- Cada equipo ve el impacto económico de sus decisiones
- Reviews de coste en cada sprint
- Accountability compartida entre tech y negocio

**Eficiencia operativa:**
- Menos desperdicio = menos coste = mejor precio
- Infraestructura compartida bien dimensionada
- Actualizaciones sin duplicar entornos
- Monitorización de coste como parte del CI/CD

**Reporting ejecutivo:**
- Dashboard de costes cloud en Grafana
- Informe mensual automático por área
- Comparativa mes a mes, trimestre a trimestre
- KPIs: coste por usuario, coste por transacción

### Beneficios para el cliente final

- **Precio justo** — La optimización de costes cloud se traslada directamente al precio de la suscripción. Menos desperdicio interno = mejor precio para el cliente.
- **Coste predecible** — Cuota mensual fija. El cliente no sufre picos de coste ni sorpresas por consumo. FinOps absorbe la variabilidad internamente.
- **Rendimiento garantizado** — Optimizar no es recortar: es dimensionar bien. El cliente recibe un servicio rápido y fiable sin pagar por recursos ociosos.

### FinOps en la práctica — Core OnBoarding

| Práctica | Qué hacemos | Herramienta |
|---------|-------------|-------------|
| Etiquetado de recursos | Todo recurso GCP tiene labels: entorno, equipo, servicio, tenant | Terraform + políticas GCP |
| Presupuestos y alertas | Budgets por proyecto GCP con alertas al 80%, 100%, 120% | GCP Billing Budgets |
| Coste por tenant | Atribución de coste por namespace K8s → tenant | Kubecost / OpenCost |
| Right-sizing | Revisión mensual de requests/limits vs uso real en pods | GKE Recommender + Grafana |
| Committed Use | Reserva de cómputo base con descuentos de hasta 57% | GCP CUD |
| Reporting | Dashboard mensual con desglose y tendencias | Grafana + BigQuery export |

---

# 14. BackOffice Core

## 14.0 Panel de Control

El **Panel de Control de Core** es la herramienta interna para gestionar instancias de bases de datos, tenants, usuarios y actualizaciones en los distintos entornos de la plataforma.

### Conceptos clave

- **Instancia de base de datos** — Conjunto de software que gestiona las bases de datos (PostgreSQL), con límites de hardware definidos. Una instancia puede contener **más de una base de datos**.
- **Bucket** — Repositorio de archivos en la nube (Google Cloud Storage) utilizado para la **Gestión Documental** de cada tenant.
- **Tenant** — El cliente final. Corresponde a una "instalación" virtual del ERP. Cada tenant puede tener varias empresas. Se le asigna un subdominio (ej: `cliente.core.com`).
- **Auth0** — Servicio de autenticación y autorización de usuarios (login). Un mismo usuario puede pertenecer a **más de un tenant**.
- **Entornos** — Conjunto de servicios (backend, frontend, etc.) desplegados en una versión concreta: Development, QA, Producción LTS, Producción Edge. Development y QA están completamente separados de Producción. Existirán dos versiones del Panel de Control para poder probar cambios.

### Secciones del panel

- **Instancias y BD** — Gestión de instancias PostgreSQL y distribución de tenants.
- **Gestión de Tenants** — Alta, bloqueo, licenciamiento y monitorización de clientes.
- **Gestión de Usuarios** — Usuarios Auth0, roles, MFA, sesiones y asociación a tenants.
- **Actualizaciones** — Releases, hotfixes, planificación y despliegue en entornos.

---

## 14.1 Instancias y Bases de Datos

Gestión de las instancias PostgreSQL y sus bases de datos, controlando la distribución de tenants y el uso de recursos.

### Funcionalidades

**Visualización de instancias:**

Ver las instancias y bases de datos en funcionamiento con su nivel de uso para distribuir correctamente los tenants:
- Cantidad de tenants por instancia
- Espacio en disco (usado / disponible)
- Datos de CPU y memoria
- Estado de salud de cada instancia

**Creación de instancias y BD:**

Crear nuevas instancias y bases de datos desde el panel:
- Provisionar nueva instancia PostgreSQL con límites de hardware
- Crear bases de datos dentro de una instancia existente
- La base de datos determina en qué **entorno** se encontrarán sus tenants

### Modelo de distribución

Instancia PostgreSQL (Hardware dedicado: CPU, RAM, disco) → Base de datos (1 o más por instancia — define el entorno) → Tenants (N tenants por base de datos)

### Evolución futura

**Mover o copiar tenants:**

En el futuro deberá existir un proceso que permita **mover o copiar tenants** entre bases de datos, para:
- **Cambiar un tenant de entorno** (por ejemplo, de Edge a LTS o viceversa)
- **Crear una copia de un tenant** para entorno de pruebas (con datos anonimizados)

---

## 14.2 Gestión de Tenants

Gestión de los clientes dados de alta en la plataforma: alta, bloqueo, licenciamiento, monitorización de recursos y configuración técnica.

### Información asociada a cada tenant

| Campo | Descripción |
|-------|-------------|
| **Identificador (GUID)** | Identificador único propio del tenant |
| **ID Auth0** | Identificador del tenant en el servicio de autenticación |
| **Nombre** | Nombre comercial del cliente |
| **URL base** | Subdominio o dominio completo (ej: `cliente.core.com`) |
| **Estado de bloqueo** | Activo / Bloqueado + motivo (mantenimiento, falta de pago, etc.) |
| **Bucket GCS** | Bucket de Google Cloud para su Gestión Documental |
| **Instancia y BD** | Instancia y base de datos donde está instalado |
| **Máx. usuarios** | Número máximo de usuarios según licencia |
| **Límites API** | Rate limits y cuotas de la API |
| **Límites Gestión Documental** | Espacio máximo de almacenamiento |

> Se requerirá una **API interna** para proveer esta información a los servicios de Core (backend, frontend, facturación, etc.). Todo servicio que necesite saber datos del tenant consultará esta API.

### Operaciones sobre tenants

**Alta de un nuevo tenant:**

El proceso de alta gestiona todos los aspectos técnicos:
1. Crear el tenant en la base de datos
2. Crear el bucket para Gestión Documental
3. Inicializar los datos (empresa inicial, perfiles, etc.)
4. Forzar la carga de datos básicos (parámetros y otros)
5. Crear el subdominio, si procede
6. Configurar el tenant en Auth0

**Control y monitorización:**

Consultar el uso que hace cada tenant de los recursos:
- Cantidad de usuarios dados de alta vs. licencia
- Tamaño de la base de datos
- Uso de almacenamiento documental
- Consumo de API (requests/día)
- **Bloquear o desbloquear** el tenant (mantenimiento, impago, etc.)

### Licenciamiento

- **Usuarios** — Máximo de usuarios concurrentes o registrados según contrato.
- **API** — Rate limits y cuotas de llamadas a la API por período.
- **Almacenamiento** — Espacio máximo para documentos y adjuntos en el bucket.

> Es necesario definir cuáles son los criterios de licenciamiento del producto que se deben controlar. Podría ser útil que administradores del tenant pudieran acceder aquí para ver sus datos y gestionar ciertos aspectos de su suscripción.

---

## 14.3 Gestión de Usuarios

La tabla maestra de usuarios existe dentro de **Auth0**. La gestión principal la realizarán los propios administradores del sistema desde el frontend de Core. El Panel de Control expone una API y herramientas complementarias.

### API de gestión de usuarios

**Consulta:**

Obtener datos del usuario según Auth0:
- Código e identificador
- Correo electrónico
- Nombre completo
- Roles asignados
- Tenants a los que pertenece
- Estado (activo / bloqueado)

**Creación:**

Crear nuevos usuarios en Auth0:
- Respetar los **límites de licencia** del tenant
- Asociar el usuario a un tenant existente
- Un mismo usuario puede pertenecer a **más de un tenant**
- Asignar roles iniciales

### Operaciones disponibles

- **Desasociar usuarios** — Desasociar usuarios de un tenant. Si quedan "libres" (sin ningún tenant), borrarlos de Auth0.
- **Bloqueo / Desbloqueo** — Bloquear o desbloquear usuarios específicos dentro de un tenant.
- **Contraseñas** — Modificación o reinicio de contraseñas a través de Auth0.
- **MFA** — Gestión de autenticación multifactor (activar, desactivar, resetear dispositivos) vía Auth0.
- **Sesiones** — Ver sesiones activas, cerrar sesiones remotamente, gestionar tokens de refresco.
- **Roles** — Asignar y revocar roles a usuarios dentro de cada tenant.

> **Punto abierto:** No está claro si es necesario replicar la información de Auth0 en el panel de control o si basta con consultarla en tiempo real vía API. La decisión dependerá de los requisitos de rendimiento y de si se necesitan consultas offline o históricas.

---

## 14.4 Gestión de Actualizaciones

Planificación y despliegue de actualizaciones en los distintos entornos, con gestión de ventanas de mantenimiento y comunicación a usuarios.

### Funcionalidades del panel

**Paquetes de actualización:**
- Visualizar los paquetes que ha puesto a disposición el equipo de desarrollo
- Ver contenido de cada paquete (changelog, migraciones de BD, etc.)
- Planificar su despliegue en los distintos entornos

**Flujo de despliegue:**

Después de QA, las actualizaciones siguen este orden:

QA → Producción Edge → Producción LTS

Edge sirve a un conjunto predeterminado de clientes para validar antes de generalizar.

### Tipos de actualización

**Hotfixes:**

Se despliegan **inmediatamente**, sin mantenimiento programado ni tiempo de inactividad.
- Sin ventana de mantenimiento
- Sin downtime para el usuario
- Pueden incluir pequeños cambios en BD (crear índice concurrente, añadir campo no obligatorio)
- Según las capacidades de PostgreSQL para cambios online

**Releases:**

Requieren **mantenimiento programado**. Se programan por la noche.
- Ventana de mantenimiento planificada
- Incluyen cambios de BD, backend, frontend
- Proceso transaccional (rollback si hay error)
- Primero en Edge, luego en LTS tras validación

### Proceso de despliegue de una Release

1. **Aviso previo** — Se publica un aviso consultable por los usuarios indicando día y hora del mantenimiento programado.
2. **Aviso 15 min antes** — Se envía mensaje a todos los usuarios conectados: el mantenimiento está por comenzar, deben guardar sus datos.
3. **Cierre de sesiones** — Se cierran todas las sesiones abiertas y se marcan los tenants afectados como **bloqueados**.
4. **Parar tareas** — Se detienen las tareas de larga ejecución (vía código o deteniendo el contenedor).
5. **Despliegue** — Snapshot de BD → Actualizar BD → Deploy servicios. Si hay error: **restaurar y rollback**.
6. **Desbloqueo** — Se quita el bloqueo a los tenants y los usuarios pueden volver a ingresar.

### Garantía transaccional

> **Cualquier error durante el despliegue debe ser tratado de forma transaccional.** Si algo falla, se restauran las bases de datos desde el snapshot y se vuelven a desplegar las versiones anteriores de los servicios. No se puede dejar nada a medias.

### Entornos de producción

| Entorno | Propósito | Clientes | Cuándo recibe actualizaciones |
|---------|-----------|----------|-------------------------------|
| **Producción Edge** | Validación con clientes reales | Conjunto predeterminado de early adopters | Inmediatamente después de QA |
| **Producción LTS** | Entorno estable para el grueso de clientes | Todos los demás clientes | Tras validación exitosa en Edge |
