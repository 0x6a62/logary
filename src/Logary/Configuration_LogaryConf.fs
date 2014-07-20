﻿namespace Logary.Configuration

open Logary
open Logary.Internals
open Logary.Target

/// The logary configuration structure having a memory of all configured
/// targets as well as the rules that map log lines and metrics to them.
type LogaryConf =
  { /// A list of rules that guide what targets are invoked for a given
    /// log line or measure.
    rules    : rule list

    /// A map of the targets by name. Some targets may not have been initialised
    /// (LogaryConf describes what-is-to-be before running it, thereafter it describes
    /// what has been configured, and the targets instances aren't None anymore.)
    targets  : Map<string, TargetConf * Option<TargetInstance>>

    /// Service metadata - what name etc.
    metadata : RuntimeInfo }