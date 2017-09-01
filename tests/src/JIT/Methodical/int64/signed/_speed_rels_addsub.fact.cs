using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _int64_signed__speed_rels_addsub__speed_rels_addsub_
    {
        [OuterLoop]
        [Fact]
        public void _int64_signed__speed_rels_addsub__speed_rels_addsub_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_speed_rels_addsub\\_speed_rels_addsub.cmd");
        }
    }
}
