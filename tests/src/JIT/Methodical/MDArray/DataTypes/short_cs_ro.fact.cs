using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _MDArray_DataTypes_short_cs_ro_short_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_DataTypes_short_cs_ro_short_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\DataTypes\\short_cs_ro\\short_cs_ro.cmd");
        }
    }
}
