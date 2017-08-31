using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint32_UInt32ToString2_UInt32ToString2_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _system_uint32_UInt32ToString2_UInt32ToString2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint32\\UInt32ToString2\\UInt32ToString2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
