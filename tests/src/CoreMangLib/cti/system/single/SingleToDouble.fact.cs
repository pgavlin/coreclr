using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_single_SingleToDouble_SingleToDouble_
    {
        [OuterLoop]
        [Fact]
        public void _system_single_SingleToDouble_SingleToDouble_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\single\\SingleToDouble\\SingleToDouble.cmd");
        }
    }
}
