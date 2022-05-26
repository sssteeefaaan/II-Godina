#pragma once
#include "graph.h"

void main()
{
	graph* G1 = new graph();

	G1->addNode(5);
	G1->addNode(7);
	G1->addNode(8);
	G1->addNode(4);
	G1->addNode(2);
	G1->addNode(1);
	G1->addNode(53);
	G1->addNode(17);
	G1->addNode(18);
	G1->addNode(49);
	G1->addNode(21);
	G1->addNode(11);
	G1->output(std::cout);					//	TESTING addNode(*);

	std::cout << "--------------------" << std::endl;
	G1->addEdge(1, 5);
	G1->addEdge(1, 53);
	G1->addEdge(53, 17);
	G1->addEdge(17, 53);
	G1->addEdge(8, 9);
	G1->addEdge(21, 8);
	G1->addEdge(2, 21);
	G1->addEdge(5, 4);
	G1->addEdge(4, 21);
	G1->addEdge(5, 21);
	G1->addEdge(5, 7);
	G1->addEdge(5, 17);

	G1->output(std::cout);					// TESTING addEdge(*), output(*) and getUndirected()
	std::cout << "--------------------" << std::endl;

	G1->getShortestRoute(1, 8);	//	TESTING SHORTEST PATH
	std::cout << "--------------------" << std::endl;

	G1->breadthFirst(1,std::cout);			//	TESTING breadthFirst(*)

	std::cout << "--------------------" << std::endl;
	G1->delNode(G1->getEnd()->getData());
	G1->output(std::cout);

	std::cout << "--------------------" << std::endl;
	G1->breadthFirst(2, std::cout);			//	TESTING resetFlags(*)

	G1->delEdgesToNode(G1->findNode(2));
	std::cout << "--------------------" << std::endl;
	G1->output(std::cout);					// TESTING findNode(*) and delEdgesToNode(*)

	G1->delAllNodes();
	std::cout << "--------------------" << std::endl;
	G1->output(std::cout);
	G1->addNode(12);
	G1->addNode(15);
	G1->addNode(-23);
	G1->addNode(55);
	G1->addNode(67);
	G1->addNode(49);
	G1->addNode(7);
	G1->addEdge(15, 55);
	G1->addEdge(15, -23);
	G1->addEdge(15, 67);
	G1->addEdge(12, 7);
	G1->addEdge(7, 49);
	G1->addEdge(7, 67);
	G1->addEdge(7, 15);
	G1->addEdge(49, 7);
	G1->addEdge(67, 12);
	G1->addEdge(67, 49);
	G1->addEdge(-23, 55);
	std::cout << "--------------------" << std::endl;
	G1->output(std::cout);					//	TESTING delAllNodes(*)
	G1->getShortestRoute(12, -23);	//	AND SHORTEST PATH
	std::cout << "--------------------" << std::endl;

	delete G1;
}