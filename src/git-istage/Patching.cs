        public static string ComputePatch(PatchDocument document, IEnumerable<int> lineIndexes, PatchDirection direction)
                                       .Where(k => k.IsAdditionOrRemoval())