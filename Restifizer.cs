﻿using UnityEngine;
using System.Collections;

public class Restifizer: RestifizerParams {

	private string baseUrl;

	private string clientId;
	private string clientSecret;

	public Restifizer(string baseUrl) {
		this.baseUrl = baseUrl;
	}

	public Restifizer ConfigClientAuth(string clientId, string clientSecret) {
		this.clientId = clientId;
		this.clientSecret = clientSecret;
		return this;
	}

	public RestifizerRequest Resource(string resourceName) {
		RestifizerRequest restifizerRequest = new RestifizerRequest(this);
		restifizerRequest.FetchList = true;
		restifizerRequest.Path += baseUrl + "/" + resourceName;
		return restifizerRequest;
	}


	/* RestifizerParams */
	public string GetClientId() {
		return clientId;
	}

	public string GetClientSecret() {
		return clientSecret;
	}
	
}