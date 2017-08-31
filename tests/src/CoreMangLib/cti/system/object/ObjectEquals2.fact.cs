using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_object_ObjectEquals2_ObjectEquals2_
    {
        [OuterLoop]
        [Fact]
        public void _system_object_ObjectEquals2_ObjectEquals2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\object\\ObjectEquals2\\ObjectEquals2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
