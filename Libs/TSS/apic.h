/**
 * @file
 *
 * @addtogroup TSSAPIC TSS API-C
 *
 */
#ifndef TSSAPIC_H
#define TSSAPIC_H

#include "Windows.h"

typedef void(*CallbackFunctionPointer)(void*,unsigned int, void*);


/** @defgroup MACRODEFINITIONS Macro Definitions
 * @{
 */

/** @name Supported LLRP Commands
 *  @anchor SUPPORTEDLLRPCOMMANDS
 */
///@{
#define URMSP_GET_READER_CAPABILITIES						1
#define URMSP_START_ROSPEC									22
#define URMSP_STOP_ROSPEC									23
#define URMSP_GET_ROSPECS									26

#define URMSP_ROSPECSTARTTRIGGER							179
#define URMSP_GPITRIGGERVALUE								181
#define URMSP_AISPECSTOPTRIGGER								184
#define URMSP_TAGOBSERVATIONTRIGGER							185
#define URMSP_RFTRANSMITTER									224
#define URMSP_EVENTNOTIFICATIONSTATE						245

#define URMSP_C1G2TAGINVENTORYMASK							332
#define URMSP_C1G2TAGINVENTORYSTATEAWAREFILTERACTION		333
#define URMSP_C1G2SINGULATIONCONTROL						336
#define URMSP_C1G2TAGINVENTORYSTATEAWARESINGULATIONACTION	337

#define URMSP_C1G2READ										341
#define URMSP_C1G2WRITE										342
#define URMSP_C1G2KILL										343
#define URMSP_C1G2LOCK										344
#define URMSP_C1G2LOCKPAYLOAD								345

#define URMSP_C1G2BLOCKERASE								346
#define URMSP_C1G2BLOCKWRITE								347
#define URMSP_C1G2BLOCKPERMALOCK							358
#define URMSP_C1G2GETBLOCKPERMALOCKSTATUS					359

#define URMSP_C1G2V2AUTHENTICATEANDREPLY					8555
#define URMSP_C1G2V2AUTHENTICATEANDSTORE					8556
#define URMSP_C1G2V2READBUFFER								8560
#define URMSP_C1G2V2UNTRACEABLE								8561

#define URMSP_HIGGS3BLOCKREADLOCK                           8961
#define URMSP_CUSTOMCOMMAND                                 16382

#define URMSP_SETPERIPHERALS                                16642
#define URMSP_SETPOWERMODE                                  16897
///@}

/** @name Supported LLRP Command Results
 *  @anchor Supported_LLRP_Command_Results
 */
///@{
#define URMSP_EPCDATA										241
#define URMSP_GPIEVENT										248
#define URMSP_ROSPECEVENT									249
#define URMSP_EPC_96										36096

#define URMSP_C1G2READOPSPECRESULT							349
#define URMSP_C1G2WRITEOPSPECRESULT							350
#define URMSP_C1G2KILLOPSPECRESULT							351
#define URMSP_C1G2LOCKOPSPECRESULT							352

#define URMSP_C1G2BLOCKERASEOPSPECRESULT					353
#define URMSP_C1G2BLOCKWRITEOPSPECRESULT					354
#define URMSP_C1G2BLOCKPERMALOCKOPSPECRESULT				361
#define URMSP_C1G2GETBLOCKPERMALOCKSTATUSOPSPECRESULT		362

#define URMSP_C1G2V2AUTHENTICATEANDREPLYRESULT				8566
#define URMSP_C1G2V2AUTHENTICATEANDSTORERESULT				8567
#define URMSP_C1G2V2READBUFFERRESULT						8571
#define URMSP_C1G2V2UNTRACEABLERESULT						8572

#define URMSP_HIGGS3BLOCKREADLOCKRESULT                     8962
#define URMSP_C1G2CUSTOMCOMMANDRESULT                       16383
///@}

/** @name Device Status
 *  @anchor Device_Status
 */
///@{
#define TSS_SUCCESS                 000
#define TSS_PARAMETERERROR          200
#define TSS_FIELDERROR              201
#define TSS_UNEXPECTEDPARAMETER     202
#define TSS_MISSINGPARAMETER		203
#define TSS_DUPLICATEPARAMETER  	204
#define TSS_OVERFLOWPARAMETER		205
#define TSS_OVERFLOWFIELD			206
#define TSS_UNKNOWNPARAMETER		207
#define TSS_UNKNOWNFIELD			208
#define TSS_UNSUPPORTEDPARAMETER	209
#define TSS_INVALID                 300
#define TSS_OUTOFRANGE              301
#define TSS_DEVICEERROR             401
///@}

/** @name GetReaderCapabbilities - Request Data
 *  @anchor GetReaderCapabbilities_-_Request_Data
 */
///@{
#define TSS_GENERAL_DEVICE_CAPABILITIES     1
///@}

/** @name ROSpecStartTrigger - Trigger Type
 *  @anchor ROSpecStartTrigger_-_Trigger_Type
 */
///@{
#define TSS_ROSPECSTARTTRIGGER_NULL          0
#define TSS_ROSPECSTARTTRIGGER_IMMEDIATE     1
#define TSS_ROSPECSTARTTRIGGER_PERIODIC      2
#define TSS_ROSPECSTARTTRIGGER_GPI           3
///@}

/** @name AISpecStopTrigger - Trigger Type
 *  @anchor AISpecStopTrigger_-_Trigger_Type
 */
///@{
#define TSS_AISPECSTOPTRIGGER_NULL              0
#define TSS_AISPECSTOPTRIGGER_DURATION          1
#define TSS_AISPECSTOPTRIGGER_GPITIMEOUT        2
#define TSS_AISPECSTOPTRIGGER_TAGOBSERVATION    3
///@}

/** @name EventNotification - Event Type
 *  @anchor EventNotification_-_Event_Type
 */
///@{
#define TSS_EVENTNOTIFICATION_GPI               1
#define TSS_EVENTNOTIFICATION_ROSPEC            2
///@}

/** @name EventNotification - Event State
 *  @anchor EventNotification_-_Event_State
 */
///@{
#define TSS_EVENTNOTIFICATIONSTATE_DISABLED     0
#define TSS_EVENTNOTIFICATIONSTATE_ENABLED      1
///@}

/** @name Tag memory bank
 *  @anchor Tag_memory_bank
 */
///@{
#define TSS_TAGMEMORYBANK_RESERVED     0
#define TSS_TAGMEMORYBANK_EPC          1
#define TSS_TAGMEMORYBANK_TID          2
#define TSS_TAGMEMORYBANK_USER         3
///@}

/** @name C1G2Lock Privilege
 *  @anchor C1G2Lock_Privilege
 */
///@{
#define TSS_C1G2LOCKPRIVILEGE_READWRITE     0
#define TSS_C1G2LOCKPRIVILEGE_PERMALOCK     1
#define TSS_C1G2LOCKPRIVILEGE_PERMAUNLOCK   2
#define TSS_C1G2LOCKPRIVILEGE_UNLOCK        3
///@}

/** @name C1G2Lock Datafield
 *  @anchor C1G2Lock_Datafield
 */
///@{
#define TSS_C1G2LOCKDATAFIELD_KILLPWD       0
#define TSS_C1G2LOCKDATAFIELD_ACCESSPWD     1
#define TSS_C1G2LOCKDATAFIELD_EPCMEMORY     2
#define TSS_C1G2LOCKDATAFIELD_TIDMEMORY     3
#define TSS_C1G2LOCKDATAFIELD_USERMEMORY    4
///@}

/** @name C1G2CustomCommand Frame Sync or Preamble
 *  @anchor C1G2CustomCommand_Frame_Sync_or_Preamble
 */
///@{
#define TSS_C1G2CUSTOMCOMMAND_FP_NONE           0
#define TSS_C1G2CUSTOMCOMMAND_FP_PREAMBLE       1
#define TSS_C1G2CUSTOMCOMMAND_FP_FRAMESYNC      2
///@}

/** @name C1G2CustomCommand - Bit operation
 *  @anchor C1G2CustomCommand_-_Bit_operation
 */
///@{
#define TSS_C1G2CUSTOMCOMMAND_BITOPERATION_NONE           0
#define TSS_C1G2CUSTOMCOMMAND_BITOPERATION_XORWITHRN16    1
///@}

/** @name C1G2CustomCommand - Handle
 *  @anchor C1G2CustomCommand_-_Handle
 */
///@{
#define TSS_C1G2CUSTOMCOMMAND_HANDLE_NONE       0
#define TSS_C1G2CUSTOMCOMMAND_HANDLE_ADD        1
///@}

/** @name C1G2CustomCommand - CRC
 *  @anchor C1G2CustomCommand_-_CRC
 */
///@{
#define TSS_C1G2CUSTOMCOMMAND_CRC_NONE      0
#define TSS_C1G2CUSTOMCOMMAND_CRC_ADD       1
///@}

/** @name C1G2CustomCommand - Tag reply type
 *  @anchor C1G2CustomCommand_-_Tag_reply_type
 */
///@{
#define TSS_C1G2CUSTOMCOMMAND_REPLYTYPE_NONE        1
#define TSS_C1G2CUSTOMCOMMAND_REPLYTYPE_IMEDIATE    2
#define TSS_C1G2CUSTOMCOMMAND_REPLYTYPE_DELAYED     3
#define TSS_C1G2CUSTOMCOMMAND_REPLYTYPE_INPROCESS   4
///@}

/** @name SetPeripherals
 *  @anchor SetPeripherals
 */
///@{
#define TSS_SETPERIPHERALS_DISABLED             0
#define TSS_SETPERIPHERALS_ENABLED              1
#define TSS_SETPERIPHERALS_DONOTCHANGE          15
///@}

/** @}*/

/** @addtogroup TSSAPIC TSS API-C
 * @{
 */

/** Log Structure
 *  Contains log message.
 */
typedef struct
{
    unsigned short  logLength;  /**< Log message length */
    char            log[255];   /**< Log message */
}log_t;

/** GPIEvent Structure
 *  Contains the results of reader event.
 */
typedef struct
{
    unsigned short      gPIPortNumber;  /**< General Purpose Input Port Number. */
    bool                e;              /**< Transition on an input pin of the Reader @n 0x01 = 0=>1 @n 0x00 = 1=>0 */
    unsigned char       reserved;       /**< Reserved field */
}gpievent_t;

/** GeneralDeviceCapabilities Structure
 *  Contains the informations about the reader.
 */
typedef struct
{
    unsigned short  maxNumberOfAntennaSupported;    /**< Maximum number of antena supported */
    unsigned short  reserved;                       /**< Reserved value */
    unsigned int    deviceManufacturerName;         /**< Device manufacturer identification number */
    char            modelName[4];                   /**< Reader model */
    unsigned short  firmwareVersionByteCount;       /**< Length of firmware version string */
    char            readerFirmwareVersion[255];     /**< Firmware version string */
}generalDeviceCapabilities_t;

/** ROSpecEvent Structure
 *  Contains the results of reader event.
 *
 *  |Event type|value|
 *  |------|-----|
 *  |Start of ROSpec|0|
 *  |End of ROSpec|1|
 *  |Preemption of ROSpec|2|
 *
 */
typedef struct
{
    unsigned char       eventType;          /**< Event type */
    unsigned int        rOSpecID;           /**< This is the ID of the ROSpec that started, ended or got preempted. */
    unsigned int        preemtingROSpecID;  /**< NOT SUPPORTED
                                                 This field carries the ID of the preempting ROSpec.
                                                 This field is ignored when EventType != 2.*/
}rospecevent_t;

/** c1g2EPC Structure
 *  Contains the results of the StartROSpec reader operation.
 *
 */
typedef struct
{
    unsigned short  epcLength;  /**< EPC number length */
    char            epc[255];   /**< EPC number */
}c1g2epc_t;

/** C1G2ReadOpSpecResult Structure
 *  Contains the results of the C1G2Read reader operation.
 *
 *  |Result|value|
 *  |------|-----|
 *  |C1G2READ_SUCCESS|0|
 *  |C1G2READ_NON_SPECIFIC_TAG_ERROR|1|
 *  |C1G2READ_NO_RESPONSE_FROM_TAG|2|
 *  |C1G2READ_NON_SPECIFIC_READER_ERROR|3|
 *  |C1G2READ_MEMORY_OVERRUN_ERROR|4|
 *  |C1G2READ_MEMORY_LOCKED_ERROR|5|
 *  |C1G2READ_INCORRECT_PASSWORD_ERROR|6|
 *
 */
typedef struct
{
    unsigned char   result;     /**< Result values */
    unsigned short  reserved;   /**< Reserved field */
    unsigned short  wordCount;  /**< Word Count is the number of 16-bit words received. */
    char            data[255];  /**< Read data */
}c1g2readopspecresult_t;

/** C1G2WriteOpSpecResult Structure
 *  Contains the results of the C1G2Write reader operation.
 *
 *  |Result|value|
 *  |------|-----|
 *  |C1G2WRITE_SUCCESS|0|
 *  |C1G2WRITE_TAG_MEMORY_OVERRUN_ERROR|1|
 *  |C1G2WRITE_TAG_MEMORY_LOCKED_ERROR|2|
 *  |C1G2WRITE_INSUFFICIENT_POWER_TO_PERFORM_MEMORY_WRITE_OPERATION|3|
 *  |C1G2WRITE_NON_SPECIFIC_TAG_ERROR|4|
 *  |C1G2WRITE_NO_RESPONSE_FROM_TAG|5|
 *  |C1G2WRITE_NON_SPECIFIC_READER_ERROR|6|
 *  |C1G2WRITE_INCORRECT_PASSWORD_ERROR|7|
 *
 */
typedef struct
{
    unsigned char   result;     /**< Result values */
    unsigned short  reserved;   /**< Reserved field */
    unsigned short  wordCount;  /**< Word Count is the number of 16-bit words written. */
}c1g2writeopspecresult_t;

/** C1G2KillOpSpecResult Structure
 *  Contains the results of the C1G2Kill reader operation.
 *
 *  |Result|value|
 *  |------|-----|
 *  |C1G2KILL_SUCCESS|0|
 *  |C1G2KILL_ZERO_KILL_PASSWORD_ERROR|1|
 *  |C1G2KILL_INSUFFICIENT_POWER_TO_PERFORM_KILL_OPERATION|2|
 *  |C1G2KILL_NON_SPECIFIC_TAG_ERROR|3|
 *  |C1G2KILL_NO_RESPONSE_FROM_TAG|4|
 *  |C1G2KILL_NON_SPECIFIC_READER_ERROR|5|
 *  |C1G2KILL_INCORRECT_PASSWORD_ERROR|6|
 *
 */
typedef struct
{
    unsigned char   result;     /**< Result values */
    unsigned short  reserved;   /**< Reserved field */
}c1g2killopspecresult_t;

/** C1G2LockOpSpecResult Structure
 *  Contains the results of the C1G2Lock reader operation.
 *
 *  |Result|value|
 *  |------|-----|
 *  |C1G2LOCK_SUCCESS|0|
 *  |C1G2LOCK_INSUFFICIENT_POWER_TO_PERFORM_LOCK_OPERATION|1|
 *  |C1G2LOCK_NON_SPECIFIC_TAG_ERROR|2|
 *  |C1G2LOCK_NO_RESPONSE_FROM_TAG|3|
 *  |C1G2LOCK_NON_SPECIFIC_READER_ERROR|4|
 *  |C1G2LOCK_INCORRECT_PASSWORD_ERROR|5|
 *  |C1G2LOCK_TAG_MEMORY_OVERRUN_ERROR|6|
 *  |C1G2LOCK_TAG_MEMORY_LOCKED_ERROR|7|
 *
 */
typedef struct
{
    unsigned char   result;     /**< Result values */
    unsigned short  reserved;   /**< Reserved field */
}c1g2lockopspecresult_t;

/** C1G2BlockEraseOpSpecResult Structure
 *  Contains the results of the C1G2BlockErase reader operation.
 *
 *  |Result|value|
 *  |------|-----|
 *  |C1G2BLOCKERASE_SUCCESS|0|
 *  |C1G2BLOCKERASE_TAG_MEMORY_OVERRUN_ERROR|1|
 *  |C1G2BLOCKERASE_TAG_MEMORY_LOCKED_ERROR|2|
 *  |C1G2BLOCKERASE_INSUFFICIENT_POWER_TO_PERFORM_MEMORY_WRITE_OPERATION|3|
 *  |C1G2BLOCKERASE_NON_SPECIFIC_TAG_ERROR|4|
 *  |C1G2BLOCKERASE_NO_RESPONSE_FROM_TAG|5|
 *  |C1G2BLOCKERASE_NON_SPECIFIC_READER_ERROR|6|
 *  |C1G2BLOCKERASE_INCORRECT_PASSWORD_ERROR|7|
 *
 */
typedef struct
{
    unsigned char   result;     /**< Result values */
    unsigned short  reserved;   /**< Reserved field */
    unsigned short  wordCount;  /**< Word Count is the number of 16-bit words received. */
}c1g2blockeraseopspecresult_t;

/** C1G2BlockWriteOpSpecResult Structure
 *  Contains the results of the C1G2BlockWrite reader operation.
 *
 *  |Result|value|
 *  |------|-----|
 *  |C1G2BLOCKWRITE_SUCCESS|0|
 *  |C1G2BLOCKWRITE_TAG_MEMORY_OVERRUN_ERROR|1|
 *  |C1G2BLOCKWRITE_TAG_MEMORY_LOCKED_ERROR|2|
 *  |C1G2BLOCKWRITE_INSUFFICIENT_POWER_TO_PERFORM_MEMORY_WRITE_OPERATION|3|
 *  |C1G2BLOCKWRITE_NON_SPECIFIC_TAG_ERROR|4|
 *  |C1G2BLOCKWRITE_NO_RESPONSE_FROM_TAG|5|
 *  |C1G2BLOCKWRITE_NON_SPECIFIC_READER_ERROR|6|
 *  |C1G2BLOCKWRITE_INCORRECT_PASSWORD_ERROR|7|
 *
 */
typedef struct
{
    unsigned char   result;     /**< Result values */
    unsigned short  reserved;   /**< Reserved field */
    unsigned short  wordCount;  /**< Word Count is the number of 16-bit words received. */
}c1g2blockwriteopspecresult_t;

/** C1G2BlockPermalockOpSpecResult Structure
 *  Contains the results of the C1G2BlockPermalock reader operation.
 *
 *  |Result|value|
 *  |------|-----|
 *  |C1G2BLOCKPERMALOCK_SUCCESS|0|
 *  |C1G2BLOCKPERMALOCK_INSUFFICIENT_POWER_TO_PERFORM_LOCK_OPERATION|1|
 *  |C1G2BLOCKPERMALOCK_NON_SPECIFIC_TAG_ERROR|2|
 *  |C1G2BLOCKPERMALOCK_NO_RESPONSE_FROM_TAG|3|
 *  |C1G2BLOCKPERMALOCK_NON_SPECIFIC_READER_ERROR|4|
 *  |C1G2BLOCKPERMALOCK_INCORRECT_PASSWORD_ERROR|5|
 *  |C1G2BLOCKPERMALOCK_TAG_MEMORY_OVERRUN_ERROR|6|
 *
 */
typedef struct
{
    unsigned char   result;     /**< Result values */
    unsigned short  reserved;   /**< Reserved field */
}c1g2blockpermalockopspecresult_t;

/** C1G2GetBlockPermalockOpSpecResult Structure
 *  Contains the results of the C1G2GetBlockPermalockStatus reader operation.
 *
 *  |Result|value|
 *  |------|-----|
 *  |C1G2GETBLOCKPERMALOCKSTATUS_SUCCESS|0|
 *  |C1G2GETBLOCKPERMALOCKSTATUS_NON_SPECIFIC_TAG_ERROR|1|
 *  |C1G2GETBLOCKPERMALOCKSTATUS_NO_RESPONSE_FROM_TAG|2|
 *  |C1G2GETBLOCKPERMALOCKSTATUS_NON_SPECIFIC_READER_ERROR|3|
 *  |C1G2GETBLOCKPERMALOCKSTATUS_INCORRECT_PASSWORD_ERROR|4|
 *  |C1G2GETBLOCKPERMALOCKSTATUS_TAG_MEMORY_OVERRUN_ERROR|5|
 *
 */
typedef struct
{
    unsigned char   result;                 /**< Result values */
    unsigned short  reserved;               /**< Reserved field */
    unsigned short  statusWordCount;        /**< Word Count is the number of 16-bit words received. */
    char            permalockStatus[255];   /**< Specifies the Permalock status of each block requested. */
}c1g2getblockpermalockstatusopspecresult_t;

/** C1G2V2AuthenticateAndReplyOpSpecResult Structure
 *  Contains the results of the C1G2V2AuthenticateAndReply reader operation.
 *
 *  |Result|value|
 *  |------|-----|
 *  |C1G2V2AUTHENTICATEANDREPLY_SUCCESS|0|
 *  |C1G2V2AUTHENTICATEANDREPLY_TAG_MEMORY_OVERRUN_ERROR|1|
 *  |C1G2V2AUTHENTICATEANDREPLY_TAG_MEMORY_LOCKED_ERROR|2|
 *  |C1G2V2AUTHENTICATEANDREPLY_INSUFFICIENT_POWER_TO_PERFORM_AUTHENTICATE_OPERATION|3|
 *  |C1G2V2AUTHENTICATEANDREPLY_NON_SPECIFIC_TAG_ERROR|4|
 *  |C1G2V2AUTHENTICATEANDREPLY_NOT_SUPPORTED_PARAMETER_ERROR|5|
 *  |C1G2V2AUTHENTICATEANDREPLY_INSUFFICIENT_PRIVILEGES_ERROR|6|
 *  |C1G2V2AUTHENTICATEANDREPLY_CRYPTO_SUITE_ERROR|7|
 *  |C1G2V2AUTHENTICATEANDREPLY_COMMAND_NOT_ENCAPSULATED_ERROR|8|
 *  |C1G2V2AUTHENTICATEANDREPLY_RESPONSEBUFFER_OVERFLOW_ERROR|9|
 *  |C1G2V2AUTHENTICATEANDREPLY_SECURITY_TIMEOUT_ERROR|10|
 *  |C1G2V2AUTHENTICATEANDREPLY_NO_RESPONSE_FROM_TAG|11|
 *  |C1G2V2AUTHENTICATEANDREPLY_NON_SPECIFIC_READER_ERROR|12|
 *  |C1G2V2AUTHENTICATEANDREPLY_INCORRECT_PASSWORD_ERROR|14|
 *  |C1G2V2AUTHENTICATEANDREPLY_TAG_WORKING|15|
 *  |C1G2V2AUTHENTICATEANDREPLY_CRYPTO_SUITE_NOT_SUPPORTED_ERROR|65|
 *  |C1G2V2AUTHENTICATEANDREPLY_CRYPTO_SUITE_MEMORY_OVERRUN_ERROR|67|
 *  |C1G2V2AUTHENTICATEANDREPLY_CRYPTO_SUITE_INSUFFICIENT_POWER_ERROR|75|
 *
 */
typedef struct
{
    unsigned char   result;         /**< Result values */
    unsigned short  reserved;       /**< Reserved field */
    unsigned short  messageLength;  /**< Message length in bits. */
    char            message[64];    /**< Response message to urmsp_C1G2V2AuthenticateAndReply command. */
}c1g2v2authenticateandreplyopspecresult_t;

/** C1G2V2AuthenticateAndStoreOpSpecResult Structure
 *  Contains the results of the C1G2V2AuthenticateAndStore reader operation.
 *
 *  |Result|value|
 *  |------|-----|
 *  |C1G2V2AUTHENTICATEANDSTORE_SUCCESS|0|
 *  |C1G2V2AUTHENTICATEANDSTORE_TAG_MEMORY_OVERRUN_ERROR|1|
 *  |C1G2V2AUTHENTICATEANDSTORE_TAG_MEMORY_LOCKED_ERROR|2|
 *  |C1G2V2AUTHENTICATEANDSTORE_INSUFFICIENT_POWER_TO_PERFORM_AUTHENTICATE_OPERATION|3|
 *  |C1G2V2AUTHENTICATEANDSTORE_NON_SPECIFIC_TAG_ERROR|4|
 *  |C1G2V2AUTHENTICATEANDSTORE_NOT_SUPPORTED_PARAMETER_ERROR|5|
 *  |C1G2V2AUTHENTICATEANDSTORE_INSUFFICIENT_PRIVILEGES_ERROR|6|
 *  |C1G2V2AUTHENTICATEANDSTORE_CRYPTO_SUITE_ERROR|7|
 *  |C1G2V2AUTHENTICATEANDSTORE_COMMAND_NOT_ENCAPSULATED_ERROR|8|
 *  |C1G2V2AUTHENTICATEANDSTORE_RESPONSEBUFFER_OVERFLOW_ERROR|9|
 *  |C1G2V2AUTHENTICATEANDSTORE_SECURITY_TIMEOUT_ERROR|10|
 *  |C1G2V2AUTHENTICATEANDSTORE_NO_RESPONSE_FROM_TAG|11|
 *  |C1G2V2AUTHENTICATEANDSTORE_NON_SPECIFIC_READER_ERROR|12|
 *  |C1G2V2AUTHENTICATEANDSTORE_INCORRECT_PASSWORD_ERROR|14|
 *  |C1G2V2AUTHENTICATEANDSTORE_TAG_WORKING|15|
 *  |C1G2V2AUTHENTICATEANDSTORE_CRYPTO_SUITE_NOT_SUPPORTED_ERROR|65|
 *  |C1G2V2AUTHENTICATEANDSTORE_CRYPTO_SUITE_MEMORY_OVERRUN_ERROR|67|
 *  |C1G2V2AUTHENTICATEANDSTORE_CRYPTO_SUITE_INSUFFICIENT_POWER_ERROR|75|
 *
 */
typedef struct
{
    unsigned char   result;                 /**< Result values */
    unsigned short  reserved;               /**< Reserved field */
    unsigned short  storedMessageLength;    /**< Lenght of the stored message to urmsp_C1G2V2AuthenticateAndStore command. */
}c1g2v2authenticateandstoreopspecresult_t;

/** C1G2V2UntraceableResult Structure
 *  Contains the results of the C1G2V2Untraceable reader operation.
 *
 *  |Result|value|
 *  |------|-----|
 *  |C1G2V2UNTRACEABLE_SUCCESS|0|
 *  |C1G2V2UNTRACEABLE_TAG_MEMORY_OVERRUN_ERROR|1|
 *  |C1G2V2UNTRACEABLE_TAG_MEMORY_LOCKED_ERROR|2|
 *  |C1G2V2UNTRACEABLE_INSUFFICIENT_POWER_TO_PERFORM_UNTRACEABLE_OPERATION|3|
 *  |C1G2V2UNTRACEABLE_NON_SPECIFIC_TAG_ERROR|4|
 *  |C1G2V2UNTRACEABLE_NOT_SUPPORTED_PARAMETER_ERROR|5|
 *  |C1G2V2UNTRACEABLE_INSUFFICIENT_PRIVILEGES_ERROR|6|
 *  |C1G2V2UNTRACEABLE_CRYPTO_SUITE_ERROR|7|
 *  |C1G2V2UNTRACEABLE_COMMAND_NOT_ENCAPSULATED_ERROR|8|
 *  |C1G2V2UNTRACEABLE_RESPONSEBUFFER_OVERFLOW_ERROR|9|
 *  |C1G2V2UNTRACEABLE_SECURITY_TIMEOUT_ERROR|10|
 *  |C1G2V2UNTRACEABLE_NO_RESPONSE_FROM_TAG|11|
 *  |C1G2V2UNTRACEABLE_NON_SPECIFIC_READER_ERROR|12|
 *  |C1G2V2UNTRACEABLE_INCORRECT_PASSWORD_ERROR|14|
 *
 */
typedef struct
{
    unsigned char   result;     /**< Result values */
    unsigned short  reserved;   /**< Reserved field */
}c1g2v2untraceableopspecresult_t;

/** C1G2V2ReadBufferResult Structure
 *  Contains the results of the C1G2V2ReadBuffer reader operation.
 *
 *  |Result|value|
 *  |------|-----|
 *  |C1G2V2READBUFFER_SUCCESS|0|
 *  |C1G2V2READBUFFER_TAG_MEMORY_OVERRUN_ERROR|1|
 *  |C1G2V2READBUFFER_TAG_MEMORY_LOCKED_ERROR|2|
 *  |C1G2V2READBUFFER_INSUFFICIENT_POWER_TO_PERFORM_READBUFFER_OPERATION|3|
 *  |C1G2V2READBUFFER_NON_SPECIFIC_TAG_ERROR|4|
 *  |C1G2V2READBUFFER_NOT_SUPPORTED_PARAMETER_ERROR|5|
 *  |C1G2V2READBUFFER_INSUFFICIENT_PRIVILEGES_ERROR|6|
 *  |C1G2V2READBUFFER_CRYPTO_SUITE_ERROR|7|
 *  |C1G2V2READBUFFER_COMMAND_NOT_ENCAPSULATED_ERROR|8|
 *  |C1G2V2READBUFFER_RESPONSEBUFFER_OVERFLOW_ERROR|9|
 *  |C1G2V2READBUFFER_SECURITY_TIMEOUT_ERROR|10|
 *  |C1G2V2READBUFFER_NO_RESPONSE_FROM_TAG|11|
 *  |C1G2V2READBUFFER_NON_SPECIFIC_READER_ERROR|12|
 *  |C1G2V2READBUFFER_INCORRECT_PASSWORD_ERROR|14|
 *
 */
typedef struct
{
    unsigned char   result;     /**< Result values */
    unsigned short  reserved;   /**< Reserved field */
    unsigned short  bitCount;   /**< Amount of returned data from read buffer in bits. */
    char            data[64];   /**< Data requested from read buffer. */
}c1g2v2readbufferopspecresult_t;

/** Higgs3BlockReadLockResult Structure
 *  Contains the results of the Higgs3BlockReadLock reader operation.
 *
 *  |Result|value|
 *  |------|-----|
 *  |HIGGS3BLOCKREADLOCK_SUCCESS|0|
 *  |HIGGS3BLOCKREADLOCK_INVALID_START_STATE_FIELD_VALUES|1|
 *  |HIGGS3BLOCKREADLOCK_TAG_MEMORY_OVERRUN_ERROR|2|
 *  |HIGGS3BLOCKREADLOCK_TAG_MEMORY_LOCKED_ERROR|3|
 *  |HIGGS3BLOCKREADLOCK_INSUFFICIENT_POWER_TO_PERFORM_OPERATION|4|
 *  |HIGGS3BLOCKREADLOCK_NON_SPECIFIC_TAG_ERROR|5|
 *  |HIGGS3BLOCKREADLOCK_NO_RESPONSE_FROM_TAG|6|
 *  |HIGGS3BLOCKREADLOCK_NON_SPECIFIC_READER_ERROR|7|
 *
 */
typedef struct
{
    unsigned char   result;     /**< Result values */
    unsigned short  reserved;   /**< Reserved field */
}higgs3blockreadlockresult_t;

/** C1G2CustomCommandResult Structure
 *  Contains the results of the CustomCommand Sreader operation.
 *
 *  |Result|value|
 *  |------|-----|
 *  |CUSTOMCOMMAND_SUCCESS|0|
 *  |CUSTOMCOMMAND_TAG_ERROR|1|
 *  |CUSTOMCOMMAND_NO_RESPONSE_FROM_TAG|2|
 *  |CUSTOMCOMMAND_NON_SPECIFIC_READER_ERROR|3|
 *
 */
typedef struct
{
    unsigned char   result;     /**< Result values */
    unsigned short  reserved;   /**< Reserved field */
    unsigned short  bitCount;   /**< Amount of reply data in bits. */
    char            replyData[64];  /**< Reply Data. */
}c1g2customcommandresult_t;

/** @} */

extern "C"
{
/** @addtogroup TSSAPIC TSS API-C
 * @{
 */

/** This function set the library debug message level. This function have to be called before
 *  you initialize the library.
 *
 *  @param[in] debugLevel Possible Values: 0x00 - 0x02.
 *  @n 0x00 = No debug messages
 *  @n 0x01 = Console log messages
 *  @n 0x02 = Log to file (TSS-APIC-dd-MM-yyyy.log)
 *
 */
__declspec(dllexport) void WINAPI setDebugLevel(int debugLevel);

/** This function initialize the library. This function have to be called before
 *  you start to use the library.
 *
 *  Example Usage:
 *
 *  @ref connectReader()
 *
 */
__declspec(dllexport) void WINAPI initDll();

/** @name Callback registration
 */
///@{

/** Connect a callbackfunction of choice. Function will be called each time the reader reads an EPC number.
 *  Callback function receive ::c1g2epc_t type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_StartROSpec()
 *
 */
__declspec(dllexport) void WINAPI connectCallbackEPC(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called each time the reader receive ReaderEvents:
 *  GPIEvent
 *  Callback function receive ::gpievent_t type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_EventNotificationState()
 *
 */
__declspec(dllexport) void WINAPI connectCallbackReaderEvents(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called each time the reader receive C1G2ReadResult.
 *  Callback function receive ::c1g2readopspecresult_t type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usgae:
 *
 *  @ref urmsp_C1G2Read()
 */
__declspec(dllexport) void WINAPI connectCallbackC1G2Read(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called each time the reader receive C1G2WriteReusult.
 *  Callback function receive ::c1g2writeopspecresult_t type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_C1G2Write()
 */
__declspec(dllexport) void WINAPI connectCallbackC1G2Write(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called each time the reader receive C1G2KillResult.
 *  Callback function receive ::c1g2killopspecresult_t type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_C1G2Kill()
 */
__declspec(dllexport) void WINAPI connectCallbackC1G2Kill(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called each time the reader receive C1G2LockResult.
 *  Callback function receive ::c1g2lockopspecresult_t type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_C1G2Lock()
 */
__declspec(dllexport) void WINAPI connectCallbackC1G2Lock(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called each time the reader receive C1G2BlockEraseResult.
 *  Callback function receive ::c1g2blockeraseopspecresult_t type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_C1G2BlockErase()
 */
__declspec(dllexport) void WINAPI connectCallbackC1G2BlockErase(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called each time the reader receive C1G2BlockWriteResult.
 *  Callback function receive ::c1g2blockwriteopspecresult_t type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_C1G2BlockWrite()
 */
__declspec(dllexport) void WINAPI connectCallbackC1G2BlockWrite(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called each time the reader receive C1G2BlockPermalockResult.
 *  Callback function receive ::c1g2blockpermalockopspecresult_t type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_C1G2BlockPermalock()
 */
__declspec(dllexport) void WINAPI connectCallbackC1G2BlockPermalock(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called each time the reader receive C1G2GetBlockPermalockResult.
 *  Callback function receive ::c1g2getblockpermalockstatusopspecresult_t; type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_C1G2GetBlockPermalockStatus()
 */
__declspec(dllexport) void WINAPI connectCallbackC1G2GetBlockPermalockStatus(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called each time the reader receive C1G2V2AuthenticateAndReplyResult.
 *  Callback function receive ::c1g2v2authenticateandreplyopspecresult_t type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_C1G2V2AuthenticateAndReply()
 */
__declspec(dllexport) void WINAPI connectCallbackC1G2V2AuthenticateAndReply(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called each time the reader receive C1G2V2AuthenticateAndStoreResult.
 *  Callback function receive ::c1g2v2authenticateandstoreopspecresult_t type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_C1G2V2AuthenticateAndStore()
 */
__declspec(dllexport) void WINAPI connectCallbackC1G2V2AuthenticateAndStore(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called each time the reader receive C1G2V2UntraceableResult.
 *  Callback function receive ::c1g2v2untraceableopspecresult_t; type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_C1G2V2Untraceable()
 */
__declspec(dllexport) void WINAPI connectCallbackC1G2V2Untraceable(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called each time the reader receive C1G2V2ReadBufferResult.
 *  Callback function receive ::c1g2v2readbufferopspecresult_t type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_C1G2V2ReadBuffer()
 */
__declspec(dllexport) void WINAPI connectCallbackC1G2V2ReadBuffer(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called each time the reader receive Higgs3BlockReadLockResult.
 *  Callback function receive ::higgs3blockreadlockresult_t type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_Higgs3BlockReadLock()
 */
__declspec(dllexport) void WINAPI connectCallbackHiggs3BlockReadLock(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called each time the reader receive CustomCommandResult.
 *  Callback function receive ::c1g2customcommandresult_t type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_C1G2CustomCommand()
 */
__declspec(dllexport) void WINAPI connectCallbackC1G2CustomCommand(CallbackFunctionPointer cbf, void *cb);

/** Connect a callbackfunction of choice. Function will be called for logging purposes(serial
 *  port communication, errors, messages).
 *  Callback function receive ::log_t type structure.
 *
 *  @param[in] cbf Pointer to a Static member function (SomeClass::someCallbackFunction).
 *  @param[in] cb Object pointer (someclass)
 *
 *  Example Usage:
 *
 *  @ref urmsp_StartROSpec()
 */
__declspec(dllexport) void WINAPI connectCallbackLog(CallbackFunctionPointer cbf, void *cb);
///@}

/** This function opens the serial port connection to reader. It must be called before any other call.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *  @param[in] comPort Com port number (COM1, COM2, ...)
 *
 *  Example Usage:
 *
 *  @include connectdisconnectexp.h
 *  @include connectdisconnectexp.cpp
 *
 */
__declspec(dllexport) int WINAPI connectReader(char *comPort);

/** This function opens TCP/IP connection to reader. It must be called before any other call.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *  @param[in] host host IPv4 address e.g. "192.168.0.110"
 *  @param[in] port host port number e.g. "5000"
 *
 */
__declspec(dllexport) int WINAPI connectReaderTCP(char *host, unsigned int port);

/** This function closes the connection to reader.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  Example Usage:
 *
 *  @ref connectReader()
 *
 */
__declspec(dllexport) int WINAPI disconnectReader();

/** @cond DEPRECATED
 *  This function waits in event loop until the specified result is received or
 *  timeout expires.
 *
 *  |Result type|value|return structure|
 *  |-----------|-----|----------------|
 *  |URMSP_C1G2READOPSPECRESULT|349|c1g2readopspecresult_t|
 *  |URMSP_C1G2WRITEOPSPECRESULT|350|c1g2writeopspecresult_t|
 *  |URMSP_C1G2WRITEOPSPECRESULT|351|c1g2killopspecresult_t|
 *  |URMSP_C1G2WRITEOPSPECRESULT|352|c1g2lockopspecresult_t|
 *  |URMSP_C1G2BLOCKERASEOPSPECRESULT|353|c1g2blockeraseopspecresult_t|
 *  |URMSP_C1G2BLOCKWRITEOPSPECRESULT|354|c1g2blockwriteopspecresult_t|
 *  |URMSP_C1G2BLOCKPERMALOCKOPSPECRESULT|361|c1g2blockpermalockopspecresult_t|
 *  |URMSP_C1G2GETBLOCKPERMALOCKSTATUSOPSPECRESULT|362|c1g2getblockpermalockstatusopspecresult_t|
 *  |URMSP_C1G2V2AUTHENTICATEANDREPLYOPSPECRESULT|8566|c1g2v2authenticateandreplyopspecresult_t|
 *  |URMSP_C1G2V2AUTHENTICATEANDSTOREOPSPECRESULT|8567|c1g2v2authenticateandstoreopspecresult_t|
 *  |URMSP_C1G2V2READBUFFEROPSPECRESULT|8571|c1g2v2readbufferopspecresult_t|
 *  |URMSP_C1G2V2UNTRACEABLEOPSPECRESULT|8572|c1g2v2untraceableopspecresult_t|
 *
 *  @returns error code
 *
 *  @param[out] structPointer Returns a structure depending on the resultType parameter
 *  @param[in] resultType Possible Values(see table above).
 *  @param[in] timeout Timeout value in milliseconds.
 *  @endcond DEPRECATED
 */
__declspec(dllexport) int WINAPI waitForResultStruct(void *structPointer, unsigned int resultType, unsigned int timeout);

/** This function reads the general capabilities of the device like supported air
 *  protocols, version of the reader firmware, device hardware and software
 *  information.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[out] returnValue Returns firmware version and build number of the reader.
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] requestedData Possible Value: 0x01.
 *  @n 0x01 = Firmware version and build number.
 *
 *  Example Usage:
 *
 *  @include getreadercapabilitiesexp.h
 *  @include getreadercapabilitiesexp.cpp
 */
__declspec(dllexport) int WINAPI urmsp_GetReaderCapabilities(void* returnValue, unsigned char flags, unsigned char reserved, unsigned char requestedData);

/** This function starts the reader operation.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags
 *  @param[in] reserved
 *
 *
 *  Example Usage:
 *
 *  @include startrospecexp.h
 *  @include startrospecexp.cpp
 */
__declspec(dllexport) int WINAPI urmsp_StartROSpec(unsigned char flags, unsigned char reserved);

/** This function stops the execution of the reader operation. Urmsp_StopROSpec
 *  overrides all other priorities and stops the execution. This basically moves
 *  the reader operation state to inactive.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *
 *  Example Usage:
 *
 *  @include stoprospecexp.h
 *  @include stoprospecexp.cpp
 */
__declspec(dllexport) int WINAPI urmsp_StopROSpec(unsigned char flags, unsigned char reserved);

/** This function retrieves all the reader operation that have been configured.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[out] returnValue
 *  @n 0x01 Inactive
 *  @n 0x02 Active
 *  @param[in] flags
 *  @param[in] reserved
 *
 *  Example Usage:
 *
 *  @include getrospecexp.h
 *  @include getrospecexp.cpp
 *
 */
__declspec(dllexport) int WINAPI urmsp_GetROSpecs(unsigned char* returnValue, unsigned char flags, unsigned char reserved);

/** FUNCTION IS RESERVED FOR FUTURE USE.
 *  @n This function sets the desired reader operation trigger type.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] 	rOSpecStartTriggerType Possible Values: 0x00 - 0x03.
 *  @n 0x00 = Null – No start trigger. The only way to start the ROSpec is with a START_ROSPEC from the Client.
 *  @n 0x01 = Immediate
 *  @n 0x02 = Periodic
 *  @n 0x03 = GPI
 */
__declspec(dllexport) int WINAPI urmsp_ROSpecStartTrigger(unsigned char flags, unsigned char reserved, unsigned char rOSpecStartTriggerType);

/** FUNCTION IS RESERVED FOR FUTURE USE.
 *  @n This function sets the parameters of GPI trigger. This trigger is tied to an
 *  event on the General Purpose Input (GPI) of the Reader. The event is
 *  represented as a boolean type.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] gPIPortNum Possible Values: 0x00. General Purpose Input Port Number.
 *  @param[in] gPIEvent Possible Value: 0x00 - 0x01. The Boolean value that causes a GPI event to
 *  trigger.
 *
 *  @param[in] timeout Possible Value: 0x00. Trigger timeout in milliseconds. If set to zero, it
 *  indicates there is no timeout.
 */
__declspec(dllexport) int WINAPI urmsp_GPITriggerValue(unsigned char flags, unsigned char reserved, unsigned short gPIPortNum, unsigned char gPIEvent, unsigned int timeout);

/** This function defines the stop (i.e., terminating boundary) of an antenna inventory operation.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] aISpecStopTriggerType Possible Values: 0x00 - 0x01
 *  @n 0x00 = Null – Stop when ROSpec is done.
 *  @n 0x01 = Duration - NOT SUPPORTED
 *  @n 0x02 = GPI with a timeout value - NOT SUPPORTED
 *  @n 0x03 = Tag observation - NOT SUPPORTED
 *
 *  @param[in] durationTriggerValue Duration of AISpec in milliseconds. NOT SUPPORTED
 *
 *  Example Usage:
 *
 *  @ref urmsp_StopROSpec()
 *
 */
__declspec(dllexport) int WINAPI urmsp_AISpecStopTrigger(unsigned char flags, unsigned char reserved, unsigned char aISpecStopTriggerType, unsigned int durationTriggerValue);

/** FUNCTION IS RESERVED FOR FUTURE USE.
 *  @n This function sets the antenna inventory stop trigger related to tag
 *  observation.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] triggerType Possible Values: 0x00 - 0x04
 *  @n 0x00 = Upon seeing N tag observations, or timeout. The definition of an "observation" is
 *  vendor specific.
 *  @n 0x01 = Upon seeing no more new tag observations for T ms, or timeout. The definition of
 *  an "observation" is vendor specific.
 *  @n 0x02 = N attempts to see all tags in the FOV, or timeout.
 *  @n 0x03 = Upon seeing N unique tag observations, or timeout.
 *  @n 0x04 = Upon seeing no more new unique tag observations for T ms, or timeout.
 *
 *  @param[in] numberOfTags Number of Tags.
 *  @param[in] numberOfAttempts Number of Attemps.
 *  @param[in] t Idle time between tag responses in milliseconds.
 *  @param[in] timeout Trigger timeout value in milliseconds. If set to zero, it indicates that
 *  there is no timeout.
 */
__declspec(dllexport) int WINAPI urmsp_TagObservationTrigger(unsigned char flags, unsigned char reserved, unsigned char triggerType, unsigned short numberOfTags, unsigned short numberOfAttempts, unsigned short t, unsigned int timeout);

/** This function defines the RF transmitter information.
 *
 *  @n hopTableID: The HopTableID is the index of the frequency hop table to be
 *  used by the Reader and is used when operating in frequency-hopping
 *  regulatory regions. This field is ignored in non-frequency-hopping
 *  regulatory regions.
 *
 *  @n channelIndex: The ChannelIndex is the one-based channel index in the
 *  FixedFrequencyTable to use during transmission and is used when operating in
 *  non-frequency-hopping regulatory regions. This field is ignored in
 *  frequency-hopping regulatory regions.
 *
 *  @n transmitPower: The Transmit Power defines the transmit power for the
 *  antenna expressed as an index into the TransmitPowerTable.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] hopTableID Possible Value: 0x00 - NOT SUPPORTED
 *  @param[in] channelIndex Possible Value: 0x00 - NOT SUPPORTED
 *  @param[in] transmitPower Possible Values: 0x00 - 0x0E
 *
 *  Example Usage:
 *
 *  @include rftransmitter.h
 *  @include rftransmitter.cpp
 *
 */
__declspec(dllexport) int WINAPI urmsp_RFTransmitter(unsigned char flags, unsigned char reserved, unsigned short hopTableID, unsigned short channelIndex, unsigned short transmitPower);

/** This function is used to enable or disable notification of a single Reader
 *  event type.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] eventType Possible Values: 0x00 - 0x09.
 *  @n 0x00 = Upon hopping to next channel - NOT SUPPORTED
 *  @n 0x01 = GPI event
 *  @n 0x02 = ROSpec event (start/end/preempt)
 *  @n 0x03 = Report buffer fill warning - NOT SUPPORTED
 *  @n 0x04 = Reader exception event - NOT SUPPORTED
 *  @n 0x05 = RFSurvey event (start/end) - NOT SUPPORTED
 *  @n 0x06 = AISpec event (end) - NOT SUPPORTED
 *  @n 0x07 = AISpec event (end) with singulation details - NOT SUPPORTED
 *  @n 0x08 = Antenna event (disconnect/connect) - NOT SUPPORTED
 *  @n 0x09 = SpecLoop event - NOT SUPPORTED
 *
 *  @param[in] notificationState Possible Values: 0x00 - 0x01.
 *  @n 0x00 = Disabled
 *  @n 0x01 = Enabled
 *
 *  Example Usage:
 *
 *  @include eventnotificationstateexp.h
 *  @include eventnotificationstateexp.cpp
 *
 */
__declspec(dllexport) int WINAPI urmsp_EventNotificationState(unsigned char flags, unsigned char reserved, unsigned short eventType, unsigned char notificationState);

/** This function set the information for the tag memory data pattern used for the select operation.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] mb Memory bank to use. Possible Values: 0x00 - 0x03.
 *  @n 0x00 = RESERVED Memory
 *  @n 0x01 = EPC Memory
 *  @n 0x02 = TID Memory
 *  @n 0x03 = USER Memory
 *
 *  @param[in] pointer The first (msb) bit location of the specified memory bank against which to
 *  compare the TagMask.
 *
 *  @param[in] maskBitCount Number of bits from tagMask used for matching.
 *  @param[in] tagMask Bit array. The pattern against which to compare. If this
 *  array is empty (0 * length), the tag mask is considered a “null filter” and
 *  will match all tags.
 *
 *  Example Usage:
 *
 *  @include selecttagexp.h
 *  @include selecttagexp.cpp
 *
 */
__declspec(dllexport) int WINAPI urmsp_C1G2TagInventoryMask(unsigned char flags, unsigned char reserved, unsigned char mb, unsigned short pointer, unsigned short maskBitCount, const char *tagMask);

/** This function is used to manage the tag states during an inventory operation.
 *
 *  @n target: This value indicates which flag in the tag to modify – whether the SL flag or its
 *  inventoried flag for a particular session.
 *
 *  @n action: Describes the action for matching and non-matching tags. The actions are specific
 *  about the tag-inventory states - e.g., do nothing, assert or deassert* SL, assign
 *  inventoried S0/S1/S2/S3 to A or B.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00.
 *  @param[in] reserved Possible Value: 0x00.
 *  @param[in] target Possible Values: 0x00 - 0x04.
 *  @n 0x00 = SL
 *  @n 0x01 = Inventoried state for session S0
 *  @n 0x02 = Inventoried state for session S1
 *  @n 0x03 = Inventoried state for session S2
 *  @n 0x04 = Inventoried state for session S3
 *
 *  @param[in] action Possible Values: 0x00 - 0x07
 *  @n 0x00 = Matching tags: assert SL or inventoried state => A.
 *  @n Non-matching tags: deassert SL or inventoried state =>B.
 *  @n 0x01 = Matching tags: assert SL or inventoried state => A.
 *  @n Non-matching tags: do nothing
 *  @n 0x02 = Matching tags: do nothing
 *  @n Non-matching tags: deassert SL or inventoried state =>B
 *  @n 0x03 = Matching tags: negate SL or (A=>B, B=>A)
 *  @n Non-matching tags: do nothing
 *  @n 0x04 = Matching tags: deassert SL or inventoried state => B
 *  @n Non-matching tags: assert SL or inventoried state =>A
 *  @n 0x05 = Matching tags: deassert SL or inventoried state => B
 *  @n Non-matching tags: do nothing
 *  @n 0x06 = Matching tags: do nothing
 *  @n Non-matching tags: assert SL or inventoried state => A
 *  @n 0x07 = Matching tags: do nothing
 *  @n Non-matching tags: negate SL or (A=>B, B=>A)
 *
 *  Example Usage:
 *
 *  @ref urmsp_C1G2TagInventoryMask()
 *
 */
__declspec(dllexport) int WINAPI urmsp_C1G2TagInventoryStateAwareFilterAction(unsigned char flags, unsigned char reserved, unsigned char target, unsigned char action);

/** This function provides controls particular to the singulation process in the
 *  C1G2 air protocol. The singulation process is started using a Query command
 *  in the C1G2 protocol. The Query command describes the session number, tag
 *  state, the start Q value to use, and the RF link parameters. This Singulation
 *  Parameter specifies the session, tag state and description of the target
 *  singulation environment. The following attributes are specified to provide
 *  guidance to the Reader for the singulation algorithm:
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] s Possible Values: 0x00 - 0x03. Session number to use for the inventory operation.
 *  @n 0x00 = Session S0
 *  @n 0x01 = Session S1
 *  @n 0x02 = Session S2
 *  @n 0x03 = Session S3
 *
 *  @param[in] tagPopulation Possible Value: 0x00(Not working yet). Tag
 *  population: This is the expected tag population in the field of view of the
 *  antenna.  NOT SUPPORTED
 *
 *  @param[in] tagTransitTime Possible Value: 0x00(Not working yet). Tag transit
 *  time: This is the measure of expected tag mobility in the field of view of
 *  the antenna where this inventory operation is getting executed.  NOT SUPPORTED
 *
 */
__declspec(dllexport) int WINAPI urmsp_C1G2SingulationControl(unsigned char flags, unsigned char reserved, unsigned char s, unsigned short tagPopulation, unsigned int tagTransitTime);

/** @n i: This is the inventoried state of the target tag population in the
 *  selected session and it corresponds to the Target field of the Class1 Gen2
 *  Query command. Only tags that match the session state participate in the
 *  inventory round. If the TagInventoryStateAware flag is false, then the
 *  Reader ignores this field, and its up to the Reader implementation to
 *  determine the value of I used in the inventory round.
 *
 *  @n s: This is the state of the SL flag in the tag and it corresponds to the
 *  Sel field of the Class1 Gen2 Query command. Only tags that match that tag
 *  state participate in the inventory round. If the TagInventoryStateAware flag
 *  is false, then the Reader ignores this field, and its up to the Reader
 *  implementation to determine the value of S used in the inventory round.
 *
 *  @n a: If set to zero, reference the S field. If set to one, the S field is
 *  ignored.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved Possible Value: 0x00
 *
 *  @param[in] i Possble Values: 0x00 - 0x01
 *  @n 0x00 = State A
 *  @n 0x01 = State B
 *
 *  @param[in] s Possble Values: 0x00 - 0x01
 *  @n 0x00 = SL
 *  @n 0x01 = ~SL
 *
 *  @param[in] a Possble Values: 0x00 - 0x01
 *  @n 0x00 = State A
 *  @n 0x01 = State B
 *
 *  Example Usage:
 *
 *  @ref urmsp_C1G2TagInventoryMask()
 *
 */
__declspec(dllexport) int WINAPI urmsp_C1G2TagInventoryStateAwareSingulationAction(unsigned char flags, unsigned char reserved, bool i, bool s, bool a);

/** This function can be used to read a portion of the user memory in a tag.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] opSpecID  Possible Value: 0x00
 *  @param[in] accessPassword Access Password is the password used by the Reader to transition the
 *  tag to the secure state so that it can read from protected tag memory regions. Password
 *  length is 4 Byte(2 Word).
 *
 *  @param[in] MB Memory bank to use. Possible Values: 0x00 - 0x03.
 *  @n 0x00 = RESERVED Memory
 *  @n 0x01 = EPC Memory
 *  @n 0x02 = TID Memory
 *  @n 0x03 = USER Memory
 *
 *  @param[in] wordPointer   Starting word address.
 *  @param[in] wordCount Number of 16-bit words to be read.
 *
 *  Example Usage:
 *
 *  @include c1g2readexp.h
 *  @include c1g2readexp.cpp
 *
 */
__declspec(dllexport) int WINAPI urmsp_C1G2Read(unsigned char flags, unsigned char reserved, unsigned short opSpecID, unsigned int accessPassword, unsigned char MB, unsigned short wordPointer, unsigned short wordCount);

/** Function used to write 4 Byte(2 Word) data to chosen memory bank.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] opSpecID  Possible Value: 0x00
 *
 *  @param[in] accessPassword Access Password is the password used by the Reader to transition the
 *  tag to the secure state so that it can write to protected tag memory regions. Password
 *  length is 4 Byte(2 Word).
 *
 *  @param[in] MB Memory bank to use. Possible Values: 0x00 - 0x03.
 *  @n 0x00 = RESERVED Memory
 *  @n 0x01 = EPC Memory
 *  @n 0x02 = TID Memory
 *  @n 0x03 = USER Memory
 *
 *  @param[in] writeDataWordPointer The word addresss of the first word to be written to the chosen memory bank.
 *  @param[in] wordCount Word Count is the number of 16-bit words to be written.
 *  @param[in] writeData Write The data to write to the chosen memory bank.
 *
 *  Example Usage:
 *
 *  @include c1g2writeexp.h
 *  @include c1g2writeexp.cpp
 *
 */
__declspec(dllexport) int WINAPI urmsp_C1G2Write(unsigned char flags, unsigned char reserved, unsigned short opSpecID, unsigned int accessPassword, unsigned char MB, unsigned short writeDataWordPointer, unsigned short wordCount, unsigned short writeData);

/** This function can be used to kill a EPC Class 1 Gen 2 tag.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] opSpecID  Possible Value: 0x00
 *  @param[in] killPassword Password required to execute C1G2Kill command. Password length 4 Byte(2 Word).
 *
 *  Example Usage:
 *
 *  @include c1g2killexp.h
 *  @include c1g2killexp.cpp
 */
__declspec(dllexport) int WINAPI urmsp_C1G2Kill(unsigned char flags, unsigned char reserved, unsigned short opSpecID, unsigned int killPassword);

/** This function execute the Lock command. The five data fields for which we
 *  can define access control using the lock command are: Kill Password, Access
 *  Password, EPC memory, TID memory and User memory. The access privilege
 *  updates are expressed as a list of C1G2LockPayload Parameters, one for each
 *  memory location. The Access Password provides the password to enter the
 *  secured state. A Reader can perform a lock operation on a tag only if the
 *  tag is in the secured state. The tag enters the secured state only using the
 *  Access Password (if a non-zero value).
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] opSpecID  Possible Value: 0x00
 *  @param[in] accessPassword Access Password is the password used by the Reader to transition the
 *  tag to the secure state so that it can write to protected tag memory regions. Password
 *  length is 4 Byte(2 Word).
 *
 *  Example Usage:
 *
 *  @include c1g2lockexp.h
 *  @include c1g2lockexp.cpp
 *
 */
__declspec(dllexport) int WINAPI urmsp_C1G2Lock(unsigned char flags, unsigned char reserved, unsigned short opSpecID, unsigned int accessPassword);

/** This function sets the access privileges (read/write/permalock). The five
 *  data fields for which we can define access control using the lock command
 *  are: Kill Password, Access Password, EPC memory, TID memory and User memory.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *
 *  @param[in] privilege Value indicates the access privilege to be applied.
 *  @n Possible Values: 0x00 - 0x03
 *  @n 0x00 = Read/Write
 *  @n 0x01 = Permalock
 *  @n 0x02 = Permaunlock
 *  @n 0x03 = Unlock
 *
 *  @param[in] dataField Value indicates to which data field the access privilege will be applied.
 *  @n Possible Values: 0x00 - 0x04
 *  @n 0x00 = Kill Password
 *  @n 0x01 = Access Password
 *  @n 0x02 = EPC Memory
 *  @n 0x03 = TID Memory
 *  @n 0x04 = User Memory
 *
 *  Example Usage:
 *
 *  @ref urmsp_C1G2Lock()
 *
 */
__declspec(dllexport) int WINAPI urmsp_C1G2LockPayload(unsigned char flags, unsigned char reserved, unsigned char privilege, unsigned char dataField);

/** BlockErase allows to erase multiple words in a Tag’s Reserved memory, EPC memory, TID memory, or the currently open file in User memory.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] opSpecID  Possible Value: 0x00
 *
 *  @param[in] accessPassword Access Password is the password used by the Reader to transition the
 *  tag to the secure state so that it can write to protected tag memory regions. Password
 *  length is 4 Byte(2 Word).
 *
 *  @param[in] MB Memory bank to use. Possible Values: 0x00 - 0x03.
 *  @n 0x00 = RESERVED Memory
 *  @n 0x01 = EPC Memory
 *  @n 0x02 = TID Memory
 *  @n 0x03 = USER Memory
 *
 *  @param[in] wordPointer specifies the starting word address for the memory erase, where words are 16 bits in length.
 *  @param[in] wordCount specifies the number of 16-bit words to be erased.
 *
 *  Example Usage:
 *
 *  @include c1g2blockeraseexp.h
 *  @include c1g2blockeraseexp.cpp
 *
 */
__declspec(dllexport) int WINAPI urmsp_C1G2BlockErase(unsigned char flags, unsigned char reserved, unsigned short opSpecID, unsigned int accessPassword, unsigned char MB, unsigned short wordPointer, unsigned short wordCount);

/** BlockWrite allows to write multiple words in a Tag’s Reserved memory, EPC memory, TID memory, or the currently open file in User memory.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] opSpecID  Possible Value: 0x00
 *
 *  @param[in] accessPassword Access Password is the password used by the Reader to transition the
 *  tag to the secure state so that it can write to protected tag memory regions. Password
 *  length is 4 Byte(2 Word).
 *
 *  @param[in] MB Memory bank to use. Possible Values: 0x00 - 0x03.
 *  @n 0x00 = RESERVED Memory
 *  @n 0x01 = EPC Memory
 *  @n 0x02 = TID Memory
 *  @n 0x03 = USER Memory
 *
 *  @param[in] writeDataWordPointer The word addresss of the first word to be written to the chosen memory bank.
 *  @param[in] wordCount Word Count is the number of 16-bit words to be written.
 *  @param[in] writeData Write The data to write to the chosen memory bank.
 *
 *  Example Usage:
 *
 *  @include c1g2blockwriteexp.h
 *  @include c1g2blockwriteexp.cpp
 */
__declspec(dllexport) int WINAPI urmsp_C1G2BlockWrite(unsigned char flags, unsigned char reserved, unsigned short opSpecID, unsigned int accessPassword, unsigned char MB, unsigned short writeDataWordPointer, unsigned short wordCount, const char *writeData);

/** BlockPermalock allows to Permalock one or more memory blocks in the User memory
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] opSpecID  Possible Value: 0x00
 *
 *  @param[in] accessPassword Access Password is the password used by the Reader to transition the
 *  tag to the secure state so that it can write to protected tag memory regions. Password
 *  length is 4 Byte(2 Word).
 *
 *  @param[in] MB Memory bank to use. Possible Values: 0x00 - 0x03.
 *  @n 0x00 = RESERVED Memory
 *  @n 0x01 = EPC Memory
 *  @n 0x02 = TID Memory
 *  @n 0x03 = USER Memory
 *
 *  @param[in] blockPointer specifies the starting address for Mask, in units of 16 blocks.
 *  @param[in] blockMaskWordCount specifies the range of Mask, starting at blockPointer and ending (16×BlockRange)–1 blocks later.
 *  @param[in] blockMask specifies which memory blocks a Tag permalocks.
 *  @n Mask bit = 0: Retain the current permalock setting for the corresponding memory block.
 *  @n Mask bit = 1: Permalock the corresponding memory block. If a block is already permalocked then a Tag shall retain the current permalock setting. A memory block, once permalocked, cannot be un-permalocked.
 *
 *  Example Usage:
 *
 *  @include c1g2blockpermalockexp.h
 *  @include c1g2blockpermalockexp.cpp
 *
 */
__declspec(dllexport) int WINAPI urmsp_C1G2BlockPermalock(unsigned char flags, unsigned char reserved, unsigned short opSpecID, unsigned int accessPassword, unsigned char MB, unsigned short blockPointer, unsigned short blockMaskWordCount, const char *blockMask);

/** GetBlockPermalockStatus command retrieves the BlockPermalock status from a tag.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] opSpecID  Possible Value: 0x00
 *
 *  @param[in] accessPassword Access Password is the password used by the Reader to transition the
 *  tag to the secure state so that it can write to protected tag memory regions. Password
 *  length is 4 Byte(2 Word).
 *
 *  @param[in] MB Memory bank to use. Possible Values: 0x00 - 0x03.
 *  @n 0x00 = RESERVED Memory
 *  @n 0x01 = EPC Memory
 *  @n 0x02 = TID Memory
 *  @n 0x03 = USER Memory
 *
 *  @param[in] blockPointer Specifies the starting address to retrieve in units of 16 blocks.
 *  @param[in] blockRange The range of blocks to retrieve, starting at blockPointer and ending ((16*blockRange) – 1) blocks later.
 *
 *  Example Usage:
 *
 *  @include c1g2getblockpermalockstatusexp.h
 *  @include c1g2getblockpermalockstatusexp.cpp
 */
__declspec(dllexport) int WINAPI urmsp_C1G2GetBlockPermalockStatus(unsigned char flags, unsigned char reserved, unsigned short opSpecID, unsigned int accessPassword, unsigned char MB, unsigned short blockPointer, unsigned short blockRange);

/** AuthenticateAndReply command is used to pass on data to the cryptographic processor on the Tag.
 *  The tag backscatters its response immediately after this command.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] opSpecID  Possible Value: 0x00
 *
 *  @param[in] accessPassword Access Password is the password used by the Reader to transition the
 *  tag to the secure state so that it can write to protected tag memory regions. Password
 *  length is 4 Byte(2 Word).
 *
 *  @param[in] csi selects the cryptographic suite that Tag use for the authentication as well as for all subsequent communications.
 *  @param[in] messageLength is the message length in bits.
 *  @param[in] message includes parameters for the authentication.
 *
 *  Example Usage:
 *
 *  @include c1g2v2authenticateandreplyexp.h
 *  @include c1g2v2authenticateandreplyexp.cpp
 *
 */
__declspec(dllexport) int WINAPI urmsp_C1G2V2AuthenticateAndReply(unsigned char flags, unsigned char reserved, unsigned short opSpecID, unsigned int accessPassword, unsigned char csi, unsigned short messageLength, const char *message);

/** FUNCTION IS RESERVED FOR FUTURE USE.
 *  @n AuthenticateAndStore command is used to pass on data to the cryptographic processor on the Tag.
 *  The tag response to this command is stored in responseBuffer and can be read by urmsp_C1G2V2ReadBuffer command.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] opSpecID  Possible Value: 0x00
 *
 *  @param[in] accessPassword Access Password is the password used by the Reader to transition the
 *  tag to the secure state so that it can write to protected tag memory regions. Password
 *  length is 4 Byte(2 Word).
 *
 *  @param[in] csi selects the cryptographic suite that Tag use for the authentication as well as for all subsequent communications.
 *  @param[in] storedMessageLength is the message length in bits.
 *  @param[in] message includes parameters for the authentication.
 *
 */
__declspec(dllexport) int WINAPI urmsp_C1G2V2AuthenticateAndStore(unsigned char flags, unsigned char reserved, unsigned short opSpecID, unsigned int accessPassword, unsigned char csi, unsigned short storedMessageLength, const char *message);

/** Untraceable allows to instruct a Tag to Hide/Unhide parts of the EPC,TID and User Memory and also reduce Tag's operation range.
 *  @n A Tag only executes Untraceable when it is in the secured state.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] opSpecID  Possible Value: 0x00
 *
 *  @param[in] accessPassword Access Password is the password used by the Reader to transition the
 *  tag to the secure state so that it can execute the Untraceable command. Password
 *  length is 4 Byte(2 Word).
 *
 *  @param[in] u Assert and Deasser U in XPC_W1. Possible value: 0x00 - 0x01.
 *  @n 0x00 = Deassert U
 *  @n 0x01 = Assert U
 *  @param[in] e Specifies whether a Tag untraceably hides part of EPC memory. Possible Values: 0x00 - 0x01.
 *  @n 0x00 = Tag exposes EPC memory.
 *  @n 0x01 = Tag untraceably hides EPC memory above that set by epcLength.
 *
 *  @param[in] epcLength specifies a new EPC length.
 *  @param[in] tid specifies the TID memory that a Tag untraceably hides. Possible Values: 0x00 - 0x03.
 *  @n 0x00 = Tag exposes TID memory.
 *  @n 0x01 = If the Tag’s allocation class identifier is E0h then the Tag untraceably hides TID memory above 10h, inclusive.
 *  @n        If the Tag’s allocation class identifier is E2h then the Tag untraceably hides TID memory above 20h, inclusive.
 *  @n 0x10 = Tag untraceably hides all of TID memory.
 *  @n 0x11 = Reserved.
 *
 *  @param[in] m specifies whether a Tag untraceably hides User memory. Possible value: 0x00 - 0x01
 *  @n 0x00 = Tag exposes User memory.
 *  @n 0x01 = Tag untraceably hides User memory.
 *
 *  @param[in] r specifies a Tag’s operating range. Possible value: 0x00 - 0x03.
 *  @n 0x00 = Tag persistently enables normal operating range.
 *  @n 0x01 = Tag persistently enables reduced operating range.
 *  @n 0x02 = Tag temporarily toggles its operating range (if normal then to reduced; if reduced then to normal)
 *  @n but reverts to its prior persistent operating range when the Tag loses power.
 *  @n 0x03 = Reserved
 *
 *  Example Usage:
 *
 *  @include c1g2v2untraceableexp.h
 *  @include c1g2v2untraceableexp.cpp
 *
 */
__declspec(dllexport) int WINAPI urmsp_C1G2V2Untraceable(unsigned char flags, unsigned char reserved, unsigned short opSpecID, unsigned int accessPassword, bool u, bool e, unsigned char epcLength, unsigned char tid, bool m, unsigned char r);

/** FUNCTION IS RESERVED FOR FUTURE USE.
 *  @n ReadBuffer allows to read data stored in a Tag’s ResponseBuffer.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] opSpecID  Possible Value: 0x00
 *
 *  @param[in] accessPassword Access Password is the password used by the Reader to transition the
 *  tag to the secure state so that it can write to protected tag memory regions. Password
 *  length is 4 Byte(2 Word).
 *
 *  @param[in] wordPointer specifies the starting word address for the read in units of 16 blocks.
 *  @param[in] bitCount specifies the number of bits to read.
 *
 */
__declspec(dllexport) int WINAPI urmsp_C1G2V2ReadBuffer(unsigned char flags, unsigned char reserved, unsigned short opSpecID, unsigned int accessPassword, unsigned short wordPointer, unsigned short bitCount);

/** Higgs3BlockReadLock command is used to prevent reading from selected 4 Word blocks.
 *  This command work only with ALIEN Higgs 3 Tags.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] opSpecID  Possible Value: 0x00
 *
 *  @param[in] accessPassword Access Password is the password used by the Reader to transition the
 *  tag to the secure state so that it can write to protected tag memory regions. Password
 *  length is 4 Byte(2 Word).
 *
 *  @param[in] readLockBits each bit specifies the 4 Word blocks to be locked.
 *
 *  Example Usage:
 *
 *  @include higgs3blockreadlockexp.h
 *  @include higgs3blockreadlockexp.cpp
 *
 */
__declspec(dllexport) int WINAPI  urmsp_Higgs3BlockReadLock(unsigned char flags, unsigned char reserved, unsigned short opSpecID, unsigned int accessPassword, unsigned char readLockBits);

/** C1G2CustomCommand enables the user to implement air protocol custom commands
 *  specific for particular Tag type. The content of the "command" will be sent
 *  to the Tag and the reply will be received via C1G2CustomCommand Result.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *  @param[in] opSpecID  Possible Value: 0x00
 *
 *  @param[in] accessPassword Access Password is the password used by the Reader to transition the
 *  tag to the secure state so that it can write to protected tag memory regions. Password
 *  length is 4 Byte(2 Word).
 *
 *  @param[in] fp
 *  @n Possible value:
 *  @n 0x00 = Send the command withouth a preamble or a frame-sync
 *  @n 0x01 = Send a preamble at the beining of the command
 *  @n 0x02 = Send a frame-sync at the beining of the command
 *  @n 0x03 = RFU
 *
 *  @param[in] rfu  RFU Possible Value: 0x00
 *  @param[in] bitCount Bit count of command
 *  @param[in] command Command to be sent
 *  @param[in] rfu2 RFU Possible Value: 0x00
 *  @param[in] r1
 *  @n Possible value:
 *  @n 0x00 = No Operation
 *  @n 0x01 = XOR bits [command end - 31,  command end - 16] with RN16
 *
 *  @param[in] r2
 *  @n Possible value:
 *  @n 0x00 = No Operation
 *  @n 0x01 = XOR bits [command end - 15,  command end] with RN16
 *
 *  @param[in] h Handle
 *  @n Possible value:
 *  @n 0x00 = No Operation
 *  @n 0x01 = Add Handle at the end of command
 *
 *  @param[in] c CRC
 *  @n Possible Value:
 *  @n 0x00 = No operation
 *  @n 0x01 = Add CRC-16 at the end of command
 *
 *  @param[in] rt Tag reply type.
 *  @n Possible value:
 *  @n 0x00 = RFU(None)
 *  @n 0x01 = Imediate
 *  @n 0x02 = Delayed
 *  @n 0x03 = RFU(In-Process)
 *
 *  @param[in] rfu3 RFU Possible Value: 0x00
 *  @param[in] replyBiteCount Bit count of expected tag reply
 *
 */
__declspec(dllexport) int WINAPI  urmsp_C1G2CustomCommand(unsigned char flags,unsigned char reserved,unsigned short opSpecID,unsigned int accessPassword,unsigned char fp,unsigned char rfu,unsigned short bitCount,const char *command,unsigned char rfu2,bool r1,bool r2,bool h,bool c,unsigned char rt,unsigned char rfu3,unsigned short replyBiteCount);

/** SetPeripherals command is used to configure reader pheriperals like LEDs, buzzers and push buttons.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *
 *  @param[in] powerLED
 *  @n Possible Value:
 *  @n 0x0 = Power LED off
 *  @n 0x1 = Power LED active
 *  @n 0x2 - 0x0E = RFU
 *  @n 0xF = Do not change the settings of Power LED
 *
 *  @param[in] statusLED
 *  @n Possible Value:
 *  @n 0x0 = Status LED off
 *  @n 0x1 = Status LED active
 *  @n 0x2 - 0x0E = RFU
 *  @n 0xF = Do not change the settings of Status LED
 *
 *  @param[in] buzzer
 *  @n Possible Value:
 *  @n 0x0 = Buzzer off
 *  @n 0x1 = Buzzer active
 *  @n 0x2 - 0x0E = RFU
 *  @n 0xF = Do not change the settings of Buzzer
 *
 *  @param[in] pushButton
 *  @n Possible Value:
 *  @n 0x0 = PushButton off
 *  @n 0x1 = PushButton active
 *  @n 0x2 - 0x0E = RFU
 *  @n 0xF = Do not change the settings of PushButton
 *
 *  @param[in] rfu
 *  @n Possible Value: 0x00
 *
 *  Example Usage:
 *
 *  @include setperipheralsexp.h
 *  @include setperipheralsexp.cpp
 *
 */
__declspec(dllexport) int WINAPI urmsp_SetPeripherals(unsigned char flags, unsigned char reserved, unsigned char powerLED, unsigned char statusLED, unsigned char buzzer, unsigned char pushButton, unsigned char rfu);


/** SetPowerMode command is used to change the reader power mode.
 *  The reader will wake up from power down mode by receiving any urmsp command.
 *
 *  @returns int error code. To translate error code to error message use getErrorString() function.
 *
 *  @param[in] flags Possible Value: 0x00
 *  @param[in] reserved  Possible Value: 0x00
 *
 *  @param[in] powerMode
 *  @n Possible Value:
 *  @n 0x00 = Power down mode
 *
 *  Example Usage:
 *
 *  @include setpowermodeexp.h
 *  @include setpowermodeexp.cpp
 *
 */
__declspec(dllexport) int WINAPI urmsp_SetPowerMode(unsigned char flags, unsigned char reserved, unsigned char powerMode);

/** This function trasnlate error codes to strings.
 *
 *  @param[out] errorSourceString
 *  @param[out] errorSourceStringLength
 *  @param[out] errorCodeString
 *  @param[out] errorCodeStringLength
 *  @param[in] errorCode
 */
__declspec(dllexport) void WINAPI getErrorString(char *errorSourceString, unsigned int *errorSourceStringLength, char *errorCodeString, unsigned int *errorCodeStringLength, int errorCode);

/** This function translate result codes to strings.
 *
 *  @param[out] resultString
 *  @param[out] resultStringLength
 *  @param[in] resultType
 *  @n Possible Values:
 *
 *  @ref Supported_LLRP_Command_Results
 *
 *  @param[in] resultCode
 *
 */
__declspec(dllexport) void WINAPI getResultString(char *resultString, unsigned int *resultStringLength, unsigned int resultType, char resultCode);
}
/** @}*/

/**
 *  @addtogroup EXAMPLES Examples
 *
 *  @section Access_Password_Example Access Password Example
 *
 *  @include accesspasswordexample.h
 *  @include accesspasswordexample.cpp
 */


/** @}*/

#endif // TSSAPIC_H
