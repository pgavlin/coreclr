using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _doublearray_dblarray3_cs_ro_dblarray3_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _doublearray_dblarray3_cs_ro_dblarray3_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\doublearray\\dblarray3_cs_ro\\dblarray3_cs_ro.cmd");
        }
    }
}
