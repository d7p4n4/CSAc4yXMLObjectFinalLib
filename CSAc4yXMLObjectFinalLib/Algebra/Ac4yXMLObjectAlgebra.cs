using System;
using System.Collections.Generic;
using System.Text;
using d7p4n4Namespace.PreProcessed.Class;
using d7p4n4Namespace.Final.Class;

namespace d7p4n4Namespace.Algebra.Class
{
	public class Ac4yXMLObjectAlgebra : Ac4yXMLObjectPreProcessed
	{

		public Int32 getId() {
        		return id;
        }

		public String getGUID() {
        		return GUID;
        }

		public String getSerialize() {
        		return serialize;
        }


    		public void setId(Int32 newValue) {
        		id = newValue;
        }

    		public void setGUID(String newValue) {
        		GUID = newValue;
        }

    		public void setSerialize(String newValue) {
        		serialize = newValue;
        }
	
		public Boolean hasId(){
			if(this.getId() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasGUID(){
			if(this.getGUID() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasSerialize(){
			if(this.getSerialize() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

    


	}
}
