using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_string_StringCompare1_StringCompare1_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _system_string_StringCompare1_StringCompare1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringCompare1\\StringCompare1.cmd");
        }
    }
}
