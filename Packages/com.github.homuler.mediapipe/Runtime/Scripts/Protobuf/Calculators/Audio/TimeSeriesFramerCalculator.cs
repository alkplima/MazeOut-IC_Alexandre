// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mediapipe/calculators/audio/time_series_framer_calculator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mediapipe {

  /// <summary>Holder for reflection information generated from mediapipe/calculators/audio/time_series_framer_calculator.proto</summary>
  public static partial class TimeSeriesFramerCalculatorReflection {

    #region Descriptor
    /// <summary>File descriptor for mediapipe/calculators/audio/time_series_framer_calculator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TimeSeriesFramerCalculatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9tZWRpYXBpcGUvY2FsY3VsYXRvcnMvYXVkaW8vdGltZV9zZXJpZXNfZnJh",
            "bWVyX2NhbGN1bGF0b3IucHJvdG8SCW1lZGlhcGlwZRokbWVkaWFwaXBlL2Zy",
            "YW1ld29yay9jYWxjdWxhdG9yLnByb3RvIsUDCiFUaW1lU2VyaWVzRnJhbWVy",
            "Q2FsY3VsYXRvck9wdGlvbnMSHgoWZnJhbWVfZHVyYXRpb25fc2Vjb25kcxgB",
            "IAEoARIgChVmcmFtZV9vdmVybGFwX3NlY29uZHMYAiABKAE6ATASLwogZW11",
            "bGF0ZV9mcmFjdGlvbmFsX2ZyYW1lX292ZXJsYXAYBSABKAg6BWZhbHNlEh4K",
            "EHBhZF9maW5hbF9wYWNrZXQYAyABKAg6BHRydWUSWgoPd2luZG93X2Z1bmN0",
            "aW9uGAQgASgOMjsubWVkaWFwaXBlLlRpbWVTZXJpZXNGcmFtZXJDYWxjdWxh",
            "dG9yT3B0aW9ucy5XaW5kb3dGdW5jdGlvbjoETk9ORRIiChN1c2VfbG9jYWxf",
            "dGltZXN0YW1wGAYgASgIOgVmYWxzZSIxCg5XaW5kb3dGdW5jdGlvbhIICgRO",
            "T05FEAASCwoHSEFNTUlORxABEggKBEhBTk4QAjJaCgNleHQSHC5tZWRpYXBp",
            "cGUuQ2FsY3VsYXRvck9wdGlvbnMYxaeSGCABKAsyLC5tZWRpYXBpcGUuVGlt",
            "ZVNlcmllc0ZyYW1lckNhbGN1bGF0b3JPcHRpb25z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mediapipe.CalculatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.TimeSeriesFramerCalculatorOptions), global::Mediapipe.TimeSeriesFramerCalculatorOptions.Parser, new[]{ "FrameDurationSeconds", "FrameOverlapSeconds", "EmulateFractionalFrameOverlap", "PadFinalPacket", "WindowFunction", "UseLocalTimestamp" }, null, new[]{ typeof(global::Mediapipe.TimeSeriesFramerCalculatorOptions.Types.WindowFunction) }, new pb::Extension[] { global::Mediapipe.TimeSeriesFramerCalculatorOptions.Extensions.Ext }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TimeSeriesFramerCalculatorOptions : pb::IMessage<TimeSeriesFramerCalculatorOptions>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TimeSeriesFramerCalculatorOptions> _parser = new pb::MessageParser<TimeSeriesFramerCalculatorOptions>(() => new TimeSeriesFramerCalculatorOptions());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TimeSeriesFramerCalculatorOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mediapipe.TimeSeriesFramerCalculatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TimeSeriesFramerCalculatorOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TimeSeriesFramerCalculatorOptions(TimeSeriesFramerCalculatorOptions other) : this() {
      _hasBits0 = other._hasBits0;
      frameDurationSeconds_ = other.frameDurationSeconds_;
      frameOverlapSeconds_ = other.frameOverlapSeconds_;
      emulateFractionalFrameOverlap_ = other.emulateFractionalFrameOverlap_;
      padFinalPacket_ = other.padFinalPacket_;
      windowFunction_ = other.windowFunction_;
      useLocalTimestamp_ = other.useLocalTimestamp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TimeSeriesFramerCalculatorOptions Clone() {
      return new TimeSeriesFramerCalculatorOptions(this);
    }

    /// <summary>Field number for the "frame_duration_seconds" field.</summary>
    public const int FrameDurationSecondsFieldNumber = 1;
    private readonly static double FrameDurationSecondsDefaultValue = 0D;

    private double frameDurationSeconds_;
    /// <summary>
    /// Frame duration in seconds.  Required.  Must be greater than 0.  This is
    /// rounded to the nearest integer number of samples.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double FrameDurationSeconds {
      get { if ((_hasBits0 & 1) != 0) { return frameDurationSeconds_; } else { return FrameDurationSecondsDefaultValue; } }
      set {
        _hasBits0 |= 1;
        frameDurationSeconds_ = value;
      }
    }
    /// <summary>Gets whether the "frame_duration_seconds" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasFrameDurationSeconds {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "frame_duration_seconds" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearFrameDurationSeconds() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "frame_overlap_seconds" field.</summary>
    public const int FrameOverlapSecondsFieldNumber = 2;
    private readonly static double FrameOverlapSecondsDefaultValue = 0D;

    private double frameOverlapSeconds_;
    /// <summary>
    /// Frame overlap in seconds.
    ///
    /// If emulate_fractional_frame_overlap is false (the default), then the frame
    /// overlap is rounded to the nearest integer number of samples, and the step
    /// from one frame to the next will be the difference between the number of
    /// samples in a frame and the number of samples in the overlap.
    ///
    /// If emulate_fractional_frame_overlap is true, then frame overlap will be a
    /// variable number of samples, such that the long-time average time step from
    /// one frame to the next will be the difference between the (nominal, not
    /// rounded) frame_duration_seconds and frame_overlap_seconds.  This is useful
    /// where the desired time step is not an integral number of input samples.
    ///
    /// A negative frame_overlap_seconds corresponds to skipping some input samples
    /// between each frame of emitted samples.
    ///
    /// Required that frame_overlap_seconds &lt;  frame_duration_seconds.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double FrameOverlapSeconds {
      get { if ((_hasBits0 & 2) != 0) { return frameOverlapSeconds_; } else { return FrameOverlapSecondsDefaultValue; } }
      set {
        _hasBits0 |= 2;
        frameOverlapSeconds_ = value;
      }
    }
    /// <summary>Gets whether the "frame_overlap_seconds" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasFrameOverlapSeconds {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "frame_overlap_seconds" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearFrameOverlapSeconds() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "emulate_fractional_frame_overlap" field.</summary>
    public const int EmulateFractionalFrameOverlapFieldNumber = 5;
    private readonly static bool EmulateFractionalFrameOverlapDefaultValue = false;

    private bool emulateFractionalFrameOverlap_;
    /// <summary>
    /// See frame_overlap_seconds for semantics.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EmulateFractionalFrameOverlap {
      get { if ((_hasBits0 & 16) != 0) { return emulateFractionalFrameOverlap_; } else { return EmulateFractionalFrameOverlapDefaultValue; } }
      set {
        _hasBits0 |= 16;
        emulateFractionalFrameOverlap_ = value;
      }
    }
    /// <summary>Gets whether the "emulate_fractional_frame_overlap" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasEmulateFractionalFrameOverlap {
      get { return (_hasBits0 & 16) != 0; }
    }
    /// <summary>Clears the value of the "emulate_fractional_frame_overlap" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEmulateFractionalFrameOverlap() {
      _hasBits0 &= ~16;
    }

    /// <summary>Field number for the "pad_final_packet" field.</summary>
    public const int PadFinalPacketFieldNumber = 3;
    private readonly static bool PadFinalPacketDefaultValue = true;

    private bool padFinalPacket_;
    /// <summary>
    /// Whether to pad the final packet with zeros.  If true, guarantees that all
    /// input samples (other than those that fall in gaps implied by negative
    /// frame_overlap_seconds) will be emitted.  If set to false, any partial
    /// packet at the end of the stream will be dropped.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PadFinalPacket {
      get { if ((_hasBits0 & 4) != 0) { return padFinalPacket_; } else { return PadFinalPacketDefaultValue; } }
      set {
        _hasBits0 |= 4;
        padFinalPacket_ = value;
      }
    }
    /// <summary>Gets whether the "pad_final_packet" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasPadFinalPacket {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "pad_final_packet" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPadFinalPacket() {
      _hasBits0 &= ~4;
    }

    /// <summary>Field number for the "window_function" field.</summary>
    public const int WindowFunctionFieldNumber = 4;
    private readonly static global::Mediapipe.TimeSeriesFramerCalculatorOptions.Types.WindowFunction WindowFunctionDefaultValue = global::Mediapipe.TimeSeriesFramerCalculatorOptions.Types.WindowFunction.None;

    private global::Mediapipe.TimeSeriesFramerCalculatorOptions.Types.WindowFunction windowFunction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mediapipe.TimeSeriesFramerCalculatorOptions.Types.WindowFunction WindowFunction {
      get { if ((_hasBits0 & 8) != 0) { return windowFunction_; } else { return WindowFunctionDefaultValue; } }
      set {
        _hasBits0 |= 8;
        windowFunction_ = value;
      }
    }
    /// <summary>Gets whether the "window_function" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasWindowFunction {
      get { return (_hasBits0 & 8) != 0; }
    }
    /// <summary>Clears the value of the "window_function" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearWindowFunction() {
      _hasBits0 &= ~8;
    }

    /// <summary>Field number for the "use_local_timestamp" field.</summary>
    public const int UseLocalTimestampFieldNumber = 6;
    private readonly static bool UseLocalTimestampDefaultValue = false;

    private bool useLocalTimestamp_;
    /// <summary>
    /// If use_local_timestamp is true, the output packet's timestamp is based on
    /// the last sample of the packet and it's inferred from the latest input
    /// packet's timestamp.  If false, the output packet's timestamp is based on
    /// the cumulative timestamping, which is inferred from the intial input
    /// timestamp and the cumulative number of samples.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UseLocalTimestamp {
      get { if ((_hasBits0 & 32) != 0) { return useLocalTimestamp_; } else { return UseLocalTimestampDefaultValue; } }
      set {
        _hasBits0 |= 32;
        useLocalTimestamp_ = value;
      }
    }
    /// <summary>Gets whether the "use_local_timestamp" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasUseLocalTimestamp {
      get { return (_hasBits0 & 32) != 0; }
    }
    /// <summary>Clears the value of the "use_local_timestamp" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearUseLocalTimestamp() {
      _hasBits0 &= ~32;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TimeSeriesFramerCalculatorOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TimeSeriesFramerCalculatorOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(FrameDurationSeconds, other.FrameDurationSeconds)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(FrameOverlapSeconds, other.FrameOverlapSeconds)) return false;
      if (EmulateFractionalFrameOverlap != other.EmulateFractionalFrameOverlap) return false;
      if (PadFinalPacket != other.PadFinalPacket) return false;
      if (WindowFunction != other.WindowFunction) return false;
      if (UseLocalTimestamp != other.UseLocalTimestamp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasFrameDurationSeconds) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(FrameDurationSeconds);
      if (HasFrameOverlapSeconds) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(FrameOverlapSeconds);
      if (HasEmulateFractionalFrameOverlap) hash ^= EmulateFractionalFrameOverlap.GetHashCode();
      if (HasPadFinalPacket) hash ^= PadFinalPacket.GetHashCode();
      if (HasWindowFunction) hash ^= WindowFunction.GetHashCode();
      if (HasUseLocalTimestamp) hash ^= UseLocalTimestamp.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasFrameDurationSeconds) {
        output.WriteRawTag(9);
        output.WriteDouble(FrameDurationSeconds);
      }
      if (HasFrameOverlapSeconds) {
        output.WriteRawTag(17);
        output.WriteDouble(FrameOverlapSeconds);
      }
      if (HasPadFinalPacket) {
        output.WriteRawTag(24);
        output.WriteBool(PadFinalPacket);
      }
      if (HasWindowFunction) {
        output.WriteRawTag(32);
        output.WriteEnum((int) WindowFunction);
      }
      if (HasEmulateFractionalFrameOverlap) {
        output.WriteRawTag(40);
        output.WriteBool(EmulateFractionalFrameOverlap);
      }
      if (HasUseLocalTimestamp) {
        output.WriteRawTag(48);
        output.WriteBool(UseLocalTimestamp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasFrameDurationSeconds) {
        output.WriteRawTag(9);
        output.WriteDouble(FrameDurationSeconds);
      }
      if (HasFrameOverlapSeconds) {
        output.WriteRawTag(17);
        output.WriteDouble(FrameOverlapSeconds);
      }
      if (HasPadFinalPacket) {
        output.WriteRawTag(24);
        output.WriteBool(PadFinalPacket);
      }
      if (HasWindowFunction) {
        output.WriteRawTag(32);
        output.WriteEnum((int) WindowFunction);
      }
      if (HasEmulateFractionalFrameOverlap) {
        output.WriteRawTag(40);
        output.WriteBool(EmulateFractionalFrameOverlap);
      }
      if (HasUseLocalTimestamp) {
        output.WriteRawTag(48);
        output.WriteBool(UseLocalTimestamp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasFrameDurationSeconds) {
        size += 1 + 8;
      }
      if (HasFrameOverlapSeconds) {
        size += 1 + 8;
      }
      if (HasEmulateFractionalFrameOverlap) {
        size += 1 + 1;
      }
      if (HasPadFinalPacket) {
        size += 1 + 1;
      }
      if (HasWindowFunction) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) WindowFunction);
      }
      if (HasUseLocalTimestamp) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TimeSeriesFramerCalculatorOptions other) {
      if (other == null) {
        return;
      }
      if (other.HasFrameDurationSeconds) {
        FrameDurationSeconds = other.FrameDurationSeconds;
      }
      if (other.HasFrameOverlapSeconds) {
        FrameOverlapSeconds = other.FrameOverlapSeconds;
      }
      if (other.HasEmulateFractionalFrameOverlap) {
        EmulateFractionalFrameOverlap = other.EmulateFractionalFrameOverlap;
      }
      if (other.HasPadFinalPacket) {
        PadFinalPacket = other.PadFinalPacket;
      }
      if (other.HasWindowFunction) {
        WindowFunction = other.WindowFunction;
      }
      if (other.HasUseLocalTimestamp) {
        UseLocalTimestamp = other.UseLocalTimestamp;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 9: {
            FrameDurationSeconds = input.ReadDouble();
            break;
          }
          case 17: {
            FrameOverlapSeconds = input.ReadDouble();
            break;
          }
          case 24: {
            PadFinalPacket = input.ReadBool();
            break;
          }
          case 32: {
            WindowFunction = (global::Mediapipe.TimeSeriesFramerCalculatorOptions.Types.WindowFunction) input.ReadEnum();
            break;
          }
          case 40: {
            EmulateFractionalFrameOverlap = input.ReadBool();
            break;
          }
          case 48: {
            UseLocalTimestamp = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 9: {
            FrameDurationSeconds = input.ReadDouble();
            break;
          }
          case 17: {
            FrameOverlapSeconds = input.ReadDouble();
            break;
          }
          case 24: {
            PadFinalPacket = input.ReadBool();
            break;
          }
          case 32: {
            WindowFunction = (global::Mediapipe.TimeSeriesFramerCalculatorOptions.Types.WindowFunction) input.ReadEnum();
            break;
          }
          case 40: {
            EmulateFractionalFrameOverlap = input.ReadBool();
            break;
          }
          case 48: {
            UseLocalTimestamp = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the TimeSeriesFramerCalculatorOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Optional windowing function. The default is NONE (no windowing function).
      /// </summary>
      public enum WindowFunction {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("HAMMING")] Hamming = 1,
        [pbr::OriginalName("HANN")] Hann = 2,
      }

    }
    #endregion

    #region Extensions
    /// <summary>Container for extensions for other messages declared in the TimeSeriesFramerCalculatorOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Extensions {
      public static readonly pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.TimeSeriesFramerCalculatorOptions> Ext =
        new pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.TimeSeriesFramerCalculatorOptions>(50631621, pb::FieldCodec.ForMessage(405052970, global::Mediapipe.TimeSeriesFramerCalculatorOptions.Parser));
    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code