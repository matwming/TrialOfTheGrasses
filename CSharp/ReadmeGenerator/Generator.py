import requests
import json
import os

from pathlib import Path
# request api
API_ENDPOINT = 'https://www.leetcode.com/api/problems/algorithms/'


HOMEPATH = os.getcwd()
CookiePath = os.path.join(HOMEPATH, 'cookie.json')

cookie = ''
with open(CookiePath) as cookie_json:
    data = json.load(cookie_json)
    cookie = data['cookie']

    print(str(cookie))

    cookies = dict(cookies_are= cookie)

res = requests.post(API_ENDPOINT, cookies=cookies)

print(res.text)