#pragma once

#include "Modules/ModuleManager.h"
#include "SerializableExtended.h"
#include <cereal/cereal.hpp>
#include <cereal/archives/binary.hpp>
#include <cereal/types/vector.hpp>
#include <cereal/types/utility.hpp>
#include <cereal/types/memory.hpp>



class MESSAGESERIALIZATION_API Serialization : public IModuleInterface {

public:
  template <typename TRequest>
  static void SerializeRequest(TRequest& Request, std::stringstream& InputStream)
  {
    InputStream.seekg(0);
    cereal::BinaryInputArchive ia(InputStream);
    ia(Request);
  }

  template <typename TResponse>
  static void DeserializeResponse(TResponse& Response, std::stringstream& OutputStream)
  {
    cereal::BinaryOutputArchive oa(OutputStream);
    oa(Response);
  }
  
};
