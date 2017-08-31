using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_CopyTo3_CopyTo3_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_CopyTo3_CopyTo3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\CopyTo3\\CopyTo3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
