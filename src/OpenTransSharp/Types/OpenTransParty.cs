﻿using BMEcatSharp.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Serialization;

namespace OpenTransSharp
{
    /// <summary>
    /// (Business partner)<br/>
    /// <br/>
    /// This element contains information about a business partner.<br/>
    /// If this element is used at least one of the following elements has to be specified.
    /// </summary>
    public class OpenTransParty
    {
        /// <summary>
        /// <inheritdoc cref="OpenTransParty"/>
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public OpenTransParty() { }

        /// <summary>
        /// <inheritdoc cref="OpenTransParty"/>
        /// </summary>
        /// <param name="ids"></param>
        public OpenTransParty(IEnumerable<BMEcatSharp.PartyId> ids)
        {
            if (ids is null)
            {
                throw new ArgumentNullException(nameof(ids));
            }

            Ids = ids.ToList();
        }

        /// <summary>
        /// (required) ID of the business partner<br/>
        /// <br/>
        /// Unique identifier of the business partner.<br/>
        /// PARTY_ID has to be specified as the document contains references to this element.<br/>
        /// <br/>
        /// XML-namespace: BMECAT
        /// </summary>
        [BMEXmlElement("PARTY_ID")]
        public List<global::BMEcatSharp.PartyId> Ids { get; set; } = new List<global::BMEcatSharp.PartyId>();

        /// <summary>
        /// (optional) Role of the business partner<br/>
        /// <br/>
        /// Role of the business partner in the context of this document<br/>
        /// The list of pre-defined values has been extended with 'invoice_issuer' (invoicing party), 'invoice_recipient' (invoice receiving party) and 'deliverer' (transportation party, carrier).<br/>
        /// The list of pre-defined values has been extended with 'intermediary' (intermediate party), 'marketplace' (market place), 'payer', 'remittee' and 'central_regulator' (in case of centralized settlement).<br/>
        /// The list of pre-defined values has been extended with 'other'.<br/>
        /// The list of pre-defined values has been extended with 'TrustedThirdParty'.<br/>
        /// <br/>
        /// Max length: 20
        /// </summary>
        [XmlElement("PARTY_ROLE")]
        public List<global::BMEcatSharp.PartyRole>? Roles { get; set; } = new List<global::BMEcatSharp.PartyRole>();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool RolesSpecified => Roles?.Count > 0;

        /// <summary>
        /// (optional) Address<br/>
        /// <br/>
        /// Address information of a business partner.
        /// </summary>
        [XmlElement("ADDRESS")]
        public List<Address>? Addresses { get; set; } = new List<Address>();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool AddressesSpecified => Addresses?.Count > 0;

        /// <summary>
        /// (optional) Bank account<br/>
        /// <br/>
        /// Bank account details.
        /// </summary>
        [XmlElement("ACCOUNT")]
        public List<Account>? Accounts { get; set; } = new List<Account>();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool AccountsSpecified => Accounts?.Count > 0;

        /// <summary>
        /// (optional) Additional multimedia information<br/>
        /// <br/>
        /// Information about multimedia files<br/>
        /// <br/>
        /// For example logos, company profiles or other business partner related documents could be added here.
        /// </summary>
        [XmlElement("MIME_INFO")]
        public OpenTransMimeInfo? MimeInfo { get; set; }
    }
}
