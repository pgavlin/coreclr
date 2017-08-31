using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_object_ObjectEquals1_ObjectEquals1_
    {
        [OuterLoop]
        [Fact]
        public void _system_object_ObjectEquals1_ObjectEquals1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\object\\ObjectEquals1\\ObjectEquals1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
