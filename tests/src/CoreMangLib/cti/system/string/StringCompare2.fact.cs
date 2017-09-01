using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_string_StringCompare2_StringCompare2_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _system_string_StringCompare2_StringCompare2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringCompare2\\StringCompare2.cmd");
        }
    }
}
