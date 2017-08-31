using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int_Int32CompareTo1_Int32CompareTo1_
    {
        [OuterLoop]
        [Fact]
        public void _system_int_Int32CompareTo1_Int32CompareTo1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int\\Int32CompareTo1\\Int32CompareTo1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
