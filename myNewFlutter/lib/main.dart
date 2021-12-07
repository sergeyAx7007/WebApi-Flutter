import 'package:flutter/material.dart';
import 'dart:async' show Future;
import 'dart:convert';
import 'package:http/http.dart' as http;

void main() {
  runApp(
    const MaterialApp(
      home: HomePage(),
    ),
  );
}

class HomePage extends StatefulWidget {
  const HomePage({Key? key}) : super(key: key);
  @override
  HomePageState createState() => HomePageState();
}

class HomePageState extends State<HomePage> {
  late List foods = [];
  bool loading = false;
  Future<String> getFoods() async {
    setState(() => loading = true);
    var response = await http.get(Uri.parse("http://$_ipServerAddress/Food"));
    setState(() => foods = json.decode(response.body.toString()));
    setState(() => loading = false);
    return 'success';
  }

  @override
  void dispose() {
    super.dispose();
  }

  @override
  void initState() {
    super.initState();
  }

  late String _ipServerAddress = "";

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      resizeToAvoidBottomInset: false,
      appBar: AppBar(
        title: const Text('My API'),
      ),
      body: Column(
        children: <Widget>[
          Container(
            margin: const EdgeInsets.only(top: 10),
            child: TextField(
              style: const TextStyle(fontSize: 24),
              decoration: const InputDecoration(
                border: OutlineInputBorder(
                  borderSide: BorderSide(
                    color: Colors.purple,
                  ),
                ),
                icon: Icon(
                  Icons.desktop_mac_sharp,
                  color: Colors.deepPurple,
                ),
                hintText: "IP Address and port...",
                labelText: "Enter the server IP address and port",
              ),
              //  keyboardType: TextInputType.number,
              onChanged: (text) {
                _ipServerAddress = text;
              },
              onSubmitted: (text) {
                _ipServerAddress = text;
                setState(
                  () {
                    getFoods();
                  },
                );
              },
            ),
          ),
          const Text(
            "My menu",
            style: TextStyle(
              fontSize: 36,
              color: Colors.indigo,
              fontWeight: FontWeight.bold,
            ),
          ),
          Container(
            child: const Divider(
              height: 20,
              color: Colors.indigo,
              thickness: 4,
            ),
          ),
          loading
              ? const Center(
                  child: CircularProgressIndicator(),
                  heightFactor: 12.0,
                )
              : Expanded(
                  child: ListView.separated(
                      itemCount: foods.length,
                      separatorBuilder: (
                        BuildContext context,
                        int index,
                      ) =>
                          const Divider(
                            height: 20,
                            color: Colors.lightBlueAccent,
                            thickness: 2,
                          ),
                      itemBuilder: (BuildContext context, int index) {
                        return Row(
                          children: <Widget>[
                            const Expanded(
                              child: Icon(
                                Icons.restaurant_menu_sharp,
                                color: Colors.blue,
                                size: 34.0,
                              ),
                              flex: 1,
                            ),
                            Expanded(
                              child: Text(
                                foods[index]['name'],
                                style: const TextStyle(
                                  fontSize: 26,
                                  color: Colors.blue,
                                ),
                              ),
                              flex: 9,
                            ),
                            Expanded(
                              child: Text(
                                foods[index]['price'].toString(),
                                style: const TextStyle(
                                  fontSize: 26,
                                  color: Colors.blue,
                                  fontWeight: FontWeight.bold,
                                ),
                              ),
                              flex: 2,
                            ),
                          ],
                        );
                      }),
                ),
        ],
      ),
    );
  }
}
