using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_CopyTo1_CopyTo1_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_CopyTo1_CopyTo1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\CopyTo1\\CopyTo1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
