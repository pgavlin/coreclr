using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_array_ArrayInitialize_ArrayInitialize_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayInitialize_ArrayInitialize_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayInitialize\\ArrayInitialize.cmd");
        }
    }
}
