using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_string_StringEmpty_StringEmpty_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringEmpty_StringEmpty_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringEmpty\\StringEmpty.cmd");
        }
    }
}
