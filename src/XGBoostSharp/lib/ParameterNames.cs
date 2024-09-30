﻿namespace XGBoostSharp.lib;

public static class ParameterNames
{
    // Keep original xgboost parameter names for variables. This makes it easier
    // to compare against the original xgboost code.
#pragma warning disable IDE1006 // Naming Styles
    public const string max_depth = nameof(max_depth);
    public const string learning_rate = nameof(learning_rate);
    public const string n_estimators = nameof(n_estimators);
    public const string silent = nameof(silent);
    public const string objective = nameof(objective);
    public const string booster = nameof(booster);
    public const string tree_method = nameof(tree_method);
    public const string nthread = nameof(nthread);
    public const string gamma = nameof(gamma);
    public const string min_child_weight = nameof(min_child_weight);
    public const string max_delta_step = nameof(max_delta_step);
    public const string subsample = nameof(subsample);
    public const string colsample_bytree = nameof(colsample_bytree);
    public const string colsample_bylevel = nameof(colsample_bylevel);
    public const string reg_alpha = nameof(reg_alpha);
    public const string reg_lambda = nameof(reg_lambda);
    public const string scale_pos_weight = nameof(scale_pos_weight);
    public const string base_score = nameof(base_score);
    public const string seed = nameof(seed);
    public const string missing = nameof(missing);
    public const string sample_type = nameof(sample_type);
    public const string normalize_type = nameof(normalize_type);
    public const string rate_drop = nameof(rate_drop);
    public const string one_drop = nameof(one_drop);
    public const string skip_drop = nameof(skip_drop);
    public const string num_class = nameof(num_class);
    public const string _Booster = nameof(_Booster);
#pragma warning restore IDE1006 // Naming Styles
}
