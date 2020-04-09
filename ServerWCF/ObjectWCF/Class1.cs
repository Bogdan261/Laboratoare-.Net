using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MyPhotos;

namespace ObjectWCF
{
    [ServiceContract]
    public interface InterfaceMyPhotos
    {

        [OperationContract]
        int insertFiles(string fileName, string filePath, string fileType, DateTime creation, List<string> personNames, List<string> locationNames, List<string> eventNames, List<string> propertys);
        [OperationContract]
        void modifyFiles(string fileName, string filePath, List<string> personNames, List<string> locationNames, List<string> eventNames, List<string> propertys);
        [OperationContract]
        void deleteFiles(string fileName, string filePath);
        [OperationContract]
        List<string> getPersons();
        [OperationContract]
        List<string> getLocations();
        [OperationContract]
        List<string> getEvents();
        [OperationContract]
        List<string> getPropertys();
        [OperationContract]
        List<string> getFilesPath();
        [OperationContract]
        List<string> getFileDetails(string path);       
        [OperationContract]
        List<string> searchFile(string fileName, string filePath, string fileType, DateTime creation, bool searchDate, List<string> personNames, List<string> locationNames, List<string> eventNames, List<string> propertys);

    }

    public class MyPhotosWCF : InterfaceMyPhotos
    {
        int InterfaceMyPhotos.insertFiles(string fileName, string filePath, string fileType, DateTime creation, List<string> personNames, List<string> locationNames, List<string> eventNames, List<string> propertys)
        {

            return MyPhotos.Class1.insertFiles(fileName, filePath, fileType, creation, personNames, locationNames, eventNames, propertys);
        }

        void InterfaceMyPhotos.modifyFiles(string fileName, string filePath, List<string> personNames, List<string> locationNames, List<string> eventNames, List<string> propertys)
        {
            MyPhotos.Class1.modifyFiles(fileName, filePath, personNames, locationNames, eventNames, propertys);


        }
        void InterfaceMyPhotos.deleteFiles(string fileName, string filePath)
        {
            MyPhotos.Class1.deleteFiles(fileName, filePath);

        }
        List<string> InterfaceMyPhotos.getPersons()
        {
            return MyPhotos.Class1.getPersons();
        }
        List<string> InterfaceMyPhotos.getLocations()
        {
            return MyPhotos.Class1.getLocations();

        }
        List<string> InterfaceMyPhotos.getEvents()
        {
            return MyPhotos.Class1.getEvents();

        }
     
        List<string> InterfaceMyPhotos.getPropertys()
        {
            return MyPhotos.Class1.getPropertys();
        }
      
        List<string> InterfaceMyPhotos.getFilesPath()
        {
            return MyPhotos.Class1.getFilesPath();

        }
       
        List<string> InterfaceMyPhotos.getFileDetails(string path)
        {
            return MyPhotos.Class1.getFileDetails(path);
        }
        List<string> InterfaceMyPhotos.searchFile(string fileName, string filePath, string fileType, DateTime creation, bool searchDate, List<string> personNames, List<string> locationNames, List<string> eventNames, List<string> propertys)
        {

            return MyPhotos.Class1.searchFile(fileName, filePath, fileType, creation, searchDate, personNames, locationNames, eventNames, propertys);
        }
    }    
}
