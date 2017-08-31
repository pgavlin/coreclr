using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_object_ObjectReferenceEquals_ObjectReferenceEquals_
    {
        [OuterLoop]
        [Fact]
        public void _system_object_ObjectReferenceEquals_ObjectReferenceEquals_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\object\\ObjectReferenceEquals\\ObjectReferenceEquals.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
